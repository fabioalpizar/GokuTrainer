using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Activities
{
    interface IActivity : IStrategy
    {
        int Duration { get; set; }
        string Name { get; set; }
    }
}
