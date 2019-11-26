﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Activities
{
    interface IStrategy
    {

        ICharacter ExecuteStrat(ICharacter character);
    }
}
