using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Sleep : IStrategy
    {
        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Energy += 50;
            updatedChar.Hp += 30;
            updatedChar.Thirst -= 10;
            updatedChar.Hunger -= 10;
            updatedChar.Happiness += 20;
            return updatedChar;
        }
    }
}
