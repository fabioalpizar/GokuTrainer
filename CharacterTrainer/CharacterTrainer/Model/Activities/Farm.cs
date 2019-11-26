using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Farm : IActivity
    {

        private IConsumable item;
        private string name = "farm";
        private int duration = 3000;

        public IConsumable Item { get => item; set => item = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.AddItem(this.item);
            return updatedChar;
        }
    }
}
