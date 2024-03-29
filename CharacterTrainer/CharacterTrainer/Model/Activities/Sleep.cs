﻿using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Sleep : IActivity
    {
        private string name = "sleep";
        private int duration = 3000;

        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Energy += 50;
            updatedChar.Hp += 50;
            updatedChar.Thirst -= 10;
            updatedChar.Hunger -= 10;
            updatedChar.Happiness += 20;
            return updatedChar;
        }
    }
}
