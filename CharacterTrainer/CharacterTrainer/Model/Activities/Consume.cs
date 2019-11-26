using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Consume : IActivity
    {

        private IConsumable item;
        private string name = "consume";
        private int duration = 3000;

        public IConsumable Item { get => item; set => item = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            if (this.item.Points.Count < 3)
            {
                Food f = (Food)this.item;
                Character updatedChar = (Character)f.Consume(character);
            }
            else
            {
                Medicine m = (Medicine)this.item;
                Character updatedChar = (Character)m.Consume(character);
            }
            return character;
        }
    }
}
