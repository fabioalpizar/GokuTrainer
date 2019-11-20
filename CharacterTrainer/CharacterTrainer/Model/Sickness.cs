using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Sickness : ISicknes
    {
        private string Name;
        private string Cause;
        private List<int> Efects;

        public void sick(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
