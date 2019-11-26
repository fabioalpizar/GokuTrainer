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
        public bool Cured(Character character)
        {
            throw new NotImplementedException();
        }

        ICharacter IStrategy.ExecuteStrat(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
