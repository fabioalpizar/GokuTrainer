using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    interface IConsumable
    {
        ICharacter Consume(ICharacter character);
        string Name { get; set; }
        List<int> Points { get; set; }
        string Image { get; set; }
    }
}
