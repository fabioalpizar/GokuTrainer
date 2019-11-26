using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTrainer.Model.Activities;

namespace CharacterTrainer.Model.CharacterApi.Conditions
{
    class Sick : ICondition
    {

        private string name = "sick";

        public string Name { get => name; set => name = value; }

        public bool Cured(Character character)
        {
            if(character.Hp > 50 && character.Hunger < 105 && character.Thirst < 105)
            {
                return true;
            }
            return false;
        }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)character;
            updatedChar.Condition = "sick";
            updatedChar.Speed = 4;
            updatedChar.Hp -= 10;
            updatedChar.Happiness -= 10;
            updatedChar.Energy -= 10;
            return updatedChar;
        }
    }
}
