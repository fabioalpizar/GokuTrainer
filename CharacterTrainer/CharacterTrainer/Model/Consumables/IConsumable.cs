﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    interface IConsumable
    {
        void Consume(ICharacter character);
    }
}