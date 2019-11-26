using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTrainer.Model.Activities;

namespace CharacterTrainer.Model.CharacterApi.Conditions
{
    class Fat : ICondition
    {
        private string name = "fat";

        public string Name { get => name; set => name = value; }

        public bool Cured(Character character)
        {
            if (character.Hunger < 100 && character.Thirst < 100)
            {
                return true;
            }
            return false;
        }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)character;
            updatedChar.Condition = "fat";
            updatedChar.Speed = 1;
            updatedChar.Hp -= 10;
            updatedChar.Happiness -= 10;
            updatedChar.Energy -= 10;
            return updatedChar;
        }
    }
}
