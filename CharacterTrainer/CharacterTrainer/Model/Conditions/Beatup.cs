using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTrainer.Model.Activities;

namespace CharacterTrainer.Model.CharacterApi.Conditions
{
    class Beatup : ICondition
    {

        private string name = "beatup";

        public string Name { get => name; set => name = value; }

        public bool Cured(Character character)
        {
            if (character.Hp > 50 && character.Energy > 50 && character.Hunger > 30 && character.Thirst > 30)
            {
                return true;
            }
            return false;
        }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)character;
            updatedChar.Condition = "beatup";
            updatedChar.Hp -= 20;
            updatedChar.Happiness += 10;
            updatedChar.Energy -= 10;
            return updatedChar;
        }
    }
}
