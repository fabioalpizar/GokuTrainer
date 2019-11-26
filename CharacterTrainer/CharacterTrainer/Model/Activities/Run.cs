using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Run : IStrategy
    {
        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Energy -= 20;
            updatedChar.Thirst -= 20;
            updatedChar.Hunger -= 20;
            updatedChar.Happiness += 10;
            return updatedChar;
        }
    }
}
