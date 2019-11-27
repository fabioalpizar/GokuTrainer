using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    interface ICharacter
    {

        string LowerHealth(int damage);
        string UseAttack(ICharacter character);
        void AddAttack(string attack, List<Attack> attackList);
        void RemoveAttack(Attack atk);

    }

}
