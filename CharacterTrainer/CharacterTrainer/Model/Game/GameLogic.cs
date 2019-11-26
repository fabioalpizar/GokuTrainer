using CharacterTrainer.Model.Activities;
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

        private Character CurrentCharacter { get; set; }
        private GameTime Time { get; set; }
        private bool Running { get; set; }
        private IStrategy CurrentActivity { get; set; }
        private int AttackTime1 { get; set; }
        private int AttackTime2 { get; set; }
        private int SocializeTime { get; set; }

        public GameLogic(int dayDuration, int yearDuration)
        {
            Time = new GameTime(dayDuration, yearDuration);
            //CurrentCharacter = CharacterFactory.newCharacter();
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
            //CurrentCharacter.CheckStats();
        }

        public void NewDay()
        {
            Random rnd = new Random();
            AttackTime1 = rnd.Next(Time.GetTime());
            AttackTime2 = rnd.Next(Time.GetTime());
            SocializeTime = rnd.Next(Time.GetTime());
            CheckStats();
        }

        public void NewYear()
        {
            //CurrentCharacter.LevelUp();
        }

    }

}
