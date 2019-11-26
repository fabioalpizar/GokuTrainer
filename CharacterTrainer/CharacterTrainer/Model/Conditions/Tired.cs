using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTrainer.Model.Activities;

namespace CharacterTrainer.Model.CharacterApi.Conditions
{
    class Tired : ICondition
    {

        private string name = "tired";

        public string Name { get => name; set => name = value; }

        public bool Cured(Character character)
        {
            if (character.Energy > 50 && character.Hunger > 30 && character.Thirst > 30)
            {
                return true;
            }
            return false;
        }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)character;
            updatedChar.Condition = "tired";
            updatedChar.Speed = 3;
            updatedChar.Hp -= 10;
            updatedChar.Happiness -= 10;
            updatedChar.Energy -= 10;
            return updatedChar;
        }
    }
}
