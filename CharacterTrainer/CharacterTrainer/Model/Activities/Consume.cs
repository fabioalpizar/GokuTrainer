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
        private int duration = 2000;

        public IConsumable Item { get => item; set => item = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character, IConsumable selectedItem)
        {
            this.item = selectedItem;
            Character updatedChar;
            if (this.item.Points.Count < 3)
            {
                Food f = (Food)this.item;
                updatedChar = (Character)f.Consume(character);
                updatedChar.RemoveItem(item);
            }
            else
            {
                Medicine m = (Medicine)this.item;
                updatedChar = (Character)m.Consume(character);
                updatedChar.RemoveItem(item);
            }
            updatedChar.RemoveItem(item);
            return updatedChar;
        }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
