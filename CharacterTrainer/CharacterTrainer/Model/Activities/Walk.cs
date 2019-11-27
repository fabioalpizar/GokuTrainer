using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Walk : IActivity
    {
        private string name = "walk";
        private int duration = 0000;

        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            /*
            updatedChar.Energy -= 2;
            updatedChar.Thirst -= 2;
            updatedChar.Hunger -= 2;
            updatedChar.Happiness += 2;
            */
            return updatedChar;
        }
    }
}
