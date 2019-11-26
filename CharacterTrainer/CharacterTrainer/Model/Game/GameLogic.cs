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
            Running = true;
            IsRandomActivity = false;
            Factory = new CharacterFactory();
            CurrentCharacter = Factory.getNewCharacter();
            Time = new GameTime(dayDuration, yearDuration);
            CurrentActivity = new Walk();
            Thread thr = new Thread(new ThreadStart(GameCicle));
            thr.Start();
        }

        public void GameCicle()
        {
            while(Running)
            {
                if (Time.IsNewDay())
                {
                    if (Time.IsNewYear())
                    {
                        NewYear();
                    }
                    NewDay();
                }
                CheckRandomEvents();
                if (IsRandomActivity)
                {
                    CurrentCharacter = CurrentActivity.ExecuteStrat(CurrentCharacter);
                } else
                {
                    CurrentActivity = Controller.GetActivity();
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
                // El personaje muere
                Running = false;
                Controller.Finish(); // Mensaje para el GUI de que murio
            }
            if (CurrentCondition != null)
            {
                if (CurrentCondition.Cured((Character)this.CurrentCharacter))
                {
                    CurrentCondition = null;
                    ConditionCounter = 0;
                } else
                {
                    CurrentCharacter = CurrentCondition.ExecuteStrat(CurrentCharacter);
                }
            } else
            {
                ICondition condition = null;
                Character character = (Character)CurrentCharacter;
                if (character.Hp < 30 && character.Hunger > 100 && character.Thirst > 100)
                {
                    condition = ConditionController.findCondition("sick");
                } 
                else if (character.Energy < 30 && character.Hunger < 30 && character.Thirst < 30)
                {
                    condition = ConditionController.findCondition("tired");
                }
                else if (character.Hunger > 150 && character.Thirst > 150)
                {
                    condition = ConditionController.findCondition("fat");
                }
                else if (character.Hp < 30 && character.Energy < 30 && character.Hunger < 30 && character.Thirst < 30)
                {
                    condition = ConditionController.findCondition("beatup");
                }
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
