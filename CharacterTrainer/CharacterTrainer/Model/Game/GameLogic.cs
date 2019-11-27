using CharacterTrainer.Controller;
using CharacterTrainer.Model.Activities;
using CharacterTrainer.Model.Conditions;
using CharacterTrainer.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        private IStrategy CurrentActivity { get; set; }
        private ICondition CurrentCondition { get; set; }
        private int ConditionCounter { get; set; }
        private int AttackTime1 { get; set; }
        private int AttackTime2 { get; set; }
        private int SocializeTime { get; set; }
        private bool IsRandomActivity { get; set; }

        public GameLogic(int dayDuration, int yearDuration)
        {
            this.Controller = new ViewController();
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
                Console.WriteLine(Time.GetCurrentTime());
                if (Time.IsNewDay())
                {
                    Console.WriteLine("New day");
                    if (Time.IsNewYear())
                    {
                        Console.WriteLine("New year");
                        NewYear();
                    }
                    NewDay();
                }
                CheckRandomEvents();
                if (IsRandomActivity)
                {
                    Console.WriteLine("Random Event");
                    CurrentCharacter = CurrentActivity.ExecuteStrat(CurrentCharacter);
                } else
                {
                    Console.WriteLine("Normal Event");
                    CurrentActivity = ActivityController.findActivity(Controller.GetActivity());
                    CurrentCharacter = CurrentActivity.ExecuteStrat(CurrentCharacter);
                }
                Thread.Sleep(1000);
                Time.incrementTime();
            }
        }

        public void CheckRandomEvents()
        {
            if (Time.GetCurrentTime() == AttackTime1)
            {
                CurrentActivity = new Fight();
            }
            if (Time.GetCurrentTime() == AttackTime2)
            {
                CurrentActivity = new Fight();
            }
            if (Time.GetCurrentTime() == SocializeTime)
            {
                CurrentActivity = new Friends();
            }
        }

        public void CheckStats()
        {
            if (this.ConditionCounter > 3)
            {
                Console.WriteLine("Muere");
                // El personaje muere
                Running = false;
                Controller.Finish(); // Mensaje para el GUI de que murio
            }
            if (CurrentCondition != null)
            {
                if (CurrentCondition.Cured((Character)this.CurrentCharacter))
                {
                    Console.WriteLine("Curado");
                    CurrentCondition = null;
                    ConditionCounter = 0;
                } else
                {
                    Console.WriteLine("Enfermo");
                    CurrentCharacter = CurrentCondition.ExecuteStrat(CurrentCharacter);
                    ConditionCounter++;
                }
            } else
            {
                ICondition condition = null;
                Character character = (Character)CurrentCharacter;
                if (character.Hp < 30 && character.Hunger > 100 && character.Thirst > 100)
                {
                    Console.WriteLine("Sick");
                    condition = ConditionController.findCondition("sick");
                }
                else if (character.Energy < 30 && character.Hunger < 30 && character.Thirst < 30)
                {
                    Console.WriteLine("Tired");
                    condition = ConditionController.findCondition("tired");
                }
                else if (character.Hunger > 150 && character.Thirst > 150)
                {
                    Console.WriteLine("Fat");
                    condition = ConditionController.findCondition("fat");
                }
                else if (character.Hp < 30 && character.Energy < 30 && character.Hunger < 30 && character.Thirst < 30)
                {
                    Console.WriteLine("Beatup");
                    condition = ConditionController.findCondition("beatup");
                }
                CurrentCondition = condition;
            }
        }

        public void NewDay()
        {
            Random rnd = new Random();
            AttackTime1 = rnd.Next(Time.GetTime());
            AttackTime2 = rnd.Next(Time.GetTime());
            SocializeTime = rnd.Next(Time.GetTime());
            CurrentActivity = new Walk();
            CheckStats();
        }

        public void NewYear()
        {
            Character character = (Character)CurrentCharacter;
            character.LevelUp();
            CurrentCharacter = character;
        }

    }

}
