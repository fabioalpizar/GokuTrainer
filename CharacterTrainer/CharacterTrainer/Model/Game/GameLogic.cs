using CharacterTrainer.Controller;
using CharacterTrainer.Model.Activities;
using CharacterTrainer.Model.Conditions;
using CharacterTrainer.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterTrainer.Model
{
    class GameLogic
    {

        private ICharacter CurrentCharacter { get; set; }
        private GameTime Time { get; set; }
        private CharacterFactory Factory { get; set; }
        private ViewController Controller { get; set; }
        private ConditionController ConditionController { get; set; }
        private ActivityController ActivityController { get; set; }
        private bool Running { get; set; }
        private IActivity CurrentActivity { get; set; }
        private ICondition CurrentCondition { get; set; }
        private int ConditionCounter { get; set; }
        private int AttackTime1 { get; set; }
        private int AttackTime2 { get; set; }
        private int SocializeTime { get; set; }
        private bool IsRandomActivity { get; set; }

        public GameLogic(int dayDuration, int yearDuration, ViewController viewController)
        {
            this.Controller = viewController;
            this.ConditionController = new ConditionController();
            this.ActivityController = new ActivityController();
            this.Running = true;
            this.IsRandomActivity = false;
            this.Factory = new CharacterFactory();
            this.CurrentCharacter = Factory.getNewCharacter();
            this.Time = new GameTime(dayDuration, yearDuration);
            this.CurrentActivity = ActivityController.findActivity("walk");
            this.CurrentCondition = null;
            Thread thr = new Thread(new ThreadStart(GameCicle));
            thr.Start();
        }

        public void GameCicle()
        {
            NewDay();
            while (Running)
            {
                this.Controller.updateTime(Time.GetCurrentTime().ToString());
                if (Time.IsNewDay())
                {
                    this.Controller.updateConsole("--- New day ---");
                    this.CurrentActivity = ActivityController.findActivity("walk");
                    if (Time.IsNewYear())
                    {
                        this.Controller.updateConsole("--- New year ---");
                        NewYear();
                    }
                    NewDay();
                }
                CheckRandomEvents();
                if (IsRandomActivity)
                {

                    if (randomEvent())
                    {
                        this.Controller.updateConsole("Time: " + Time.GetCurrentTime().ToString() + " Day: " + Time.GetCurrentDay().ToString() + " Year: " + Time.GetCurrentYear().ToString());
                        this.Controller.updateConsole("Random Event: " + CurrentActivity.Name);
                        this.Controller.updateActivity(CurrentActivity.Name);
                        CurrentCharacter = CurrentActivity.ExecuteStrat(CurrentCharacter);
                        //Console print for fight
                        if (CurrentActivity.Name.Equals("fight"))
                        {
                            this.Controller.updateConsole("Fight log: \n" + ((Fight)CurrentActivity).Log);
                            this.Controller.Enemy = Image.FromFile(((Fight)CurrentActivity).Enemy.Images[0]);
                            this.Controller.moveSprite(((Character)this.CurrentCharacter).Speed);
                            Thread.Sleep(CurrentActivity.Duration);
                        }
                        Time.WaitActivity(CurrentActivity.Duration);
                        Thread.Sleep(CurrentActivity.Duration);
                        this.Controller.Enemy = null;
                        this.Controller.CurrentActivity = "walk";
                    }
                    
                } else {
                    CurrentActivity = ActivityController.findActivity(Controller.GetActivity());
                    if (CurrentActivity.Name.Equals("consume"))
                    {      
                        CurrentCharacter = ((Consume)CurrentActivity).ExecuteStrat(CurrentCharacter, this.Factory.getItem(this.Controller.CurrentItem));
                    } else {
                        CurrentCharacter = CurrentActivity.ExecuteStrat(CurrentCharacter);
                    }
                    if (CurrentActivity.Name.Equals("walk"))
                    {
                        this.Controller.moveSprite(((Character)this.CurrentCharacter).Speed);
                        this.Controller.updateActivity("walk");
                    }
                    else
                    {
                        this.Controller.updateConsole("Time: " + Time.GetCurrentTime().ToString() + " Day: " + Time.GetCurrentDay().ToString() + " Year: " + Time.GetCurrentYear().ToString());
                        Console.WriteLine("Normal Event: " + Controller.GetActivity());
                        this.Controller.updateConsole("Normal Event: " + Controller.GetActivity());
                    }
                    Time.WaitActivity(CurrentActivity.Duration);
                    Thread.Sleep(CurrentActivity.Duration);
                    this.Controller.CurrentActivity = "walk";
                }
                Thread.Sleep(1000);
                Time.incrementTime();
                this.Controller.updateCharInfo((Character)this.CurrentCharacter);
                if(this.CurrentCondition == null)
                {
                    this.Controller.updateOkAppearance(((Character)this.CurrentCharacter).Level);
                }
            }
        }

        public void CheckRandomEvents()
        {
            if (Time.GetCurrentTime() == AttackTime1)
            {
                CurrentActivity = new Fight();
                IsRandomActivity = true;
            }
            else if (Time.GetCurrentTime() == AttackTime2)
            {
                CurrentActivity = new Fight();
                IsRandomActivity = true;
            }
            else if (Time.GetCurrentTime() == SocializeTime)
            {
                CurrentActivity = new Friends();
                IsRandomActivity = true;
            } else {
                IsRandomActivity = false;
            }
        }

        public void CheckStats()
        {
            if (this.ConditionCounter > 3)
            {
                this.Controller.updateConsole("Your Goku died lol.");
                // El personaje muere
                Running = false;
                Controller.Finish(); // Mensaje para el GUI de que murio
            }
            if (CurrentCondition != null)
            {
                this.Controller.updateConsole("Time: " + Time.GetCurrentTime().ToString() + " Day: " + Time.GetCurrentDay().ToString() + " Year: " + Time.GetCurrentYear().ToString());
                Console.WriteLine("Random Event: " + CurrentActivity.Name);
                if (CurrentCondition.Cured((Character)this.CurrentCharacter))
                {
                    this.Controller.updateConsole("*** Your goku was cured! ***");
                    CurrentCondition = null;
                    ConditionCounter = 0;
                } else
                {
                    this.Controller.updateConsole("*** Be careful your goku is still sick ***");
                    CurrentCharacter = CurrentCondition.ExecuteStrat(CurrentCharacter);
                    ConditionCounter++;
                    this.Controller.updateConsole("Sick day coutner: " + this.ConditionCounter.ToString());
                }
            } else {
                ICondition condition = null;
                Character character = (Character)CurrentCharacter;
                this.Controller.updateConsole("Time: " + Time.GetCurrentTime().ToString() + " Day: " + Time.GetCurrentDay().ToString() + " Year: " + Time.GetCurrentYear().ToString());
                Console.WriteLine("Random Event: " + CurrentActivity.Name);
                if (character.Hp < 30 && character.Hunger < 30 && character.Thirst < 30 && newCondition())
                {
                    Console.WriteLine("Sick");
                    this.Controller.updateConditionAppearance("sick");
                    condition = ConditionController.findCondition("sick");
                }
                else if (character.Energy < 30 && newCondition())
                {
                    Console.WriteLine("Tired");
                    this.Controller.updateConditionAppearance("tired");
                    condition = ConditionController.findCondition("tired");
                }
                else if (character.Hunger > 100 && character.Thirst > 100 && newCondition())
                {
                    Console.WriteLine("Fat");
                    this.Controller.updateConditionAppearance("fat");
                    condition = ConditionController.findCondition("fat");
                }
                else if (character.Hp < 30 && newCondition())
                {
                    Console.WriteLine("Beatup");
                    this.Controller.updateConditionAppearance("beatup");
                    condition = ConditionController.findCondition("beatup");
                }
                CurrentCondition = condition;
            }
            if (this.CurrentCondition != null)
            {
                this.Controller.updateConditionAppearance(this.CurrentCondition.Name);
                this.Controller.updateConsole(((Character)this.CurrentCharacter).Name + " is currently " + this.CurrentCondition.Name);
            }
        }

        public void NewDay()
        {
            Random rnd = new Random();
            int rand1 = rnd.Next(1);
            int rand2 = rnd.Next(1);
            int rand3 = rnd.Next(1);
            if (rand1 == 0)
            {
                AttackTime1 = rnd.Next(Time.GetTime());
            }
            if (rand2 == 0)
            {
                AttackTime2 = rnd.Next(Time.GetTime());
            }
            if (rand3 == 0)
            {
                SocializeTime = rnd.Next(Time.GetTime());
            }
            this.Controller.CurrentActivity = "walk";
            IsRandomActivity = false;
            CheckStats();
            this.Controller.updateDate(this.Time.GetCurrentDay().ToString(), this.Time.GetCurrentYear().ToString());
        }

        public void NewYear()
        {
            Character character = (Character)CurrentCharacter;
            character.LevelUp();
            CurrentCharacter = character;
            this.Controller.updateDate(this.Time.GetCurrentDay().ToString(), this.Time.GetCurrentYear().ToString());
        }


        public Boolean newCondition()
        {
            string message = "Do you want to accept the condition?";
            string title = "New condition";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public Boolean randomEvent()
        {
            string message = "Would you like accept a random event?\nIt could lead to pichazos!";
            string title = "Random event incoming";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
