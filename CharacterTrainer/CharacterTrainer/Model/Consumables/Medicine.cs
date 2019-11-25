using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Medicine : IMedicine
    {
        private string name;
        private string cureFor;

        public void Cure(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
