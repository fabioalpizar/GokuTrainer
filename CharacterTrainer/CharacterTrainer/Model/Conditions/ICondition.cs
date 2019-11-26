using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    interface ICondition : IStrategy
    {
        Boolean Cured(Character character);
        string Name { get; set; }
    }
}
