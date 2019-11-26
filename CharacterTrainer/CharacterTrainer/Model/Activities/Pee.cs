using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Activities
{
    class Pee : IActivity
    {
        private string name = "pee";
        private int duration = 3000;

        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Thirst -= 30;
            return updatedChar;
        }
    }
}
