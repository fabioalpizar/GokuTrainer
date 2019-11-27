using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Spar : IActivity
    {
        private string name = "spar";
        private int duration = 3000;
        private CharacterFactory factory = new CharacterFactory();

        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Energy -= 20;
            updatedChar.Hp -= 10;
            updatedChar.Thirst -= 20;
            updatedChar.Hunger -= 20;
            updatedChar.Happiness += 10;
            updatedChar.AddAttack(this.factory.getAttack("Dragon-Punch"));
            return updatedChar;
        }
    }
}
