using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    interface ICharacter
    {

        void LowerHealth(int damage);
        void UseAttack(string attack, ICharacter character);
        void AddAttack(string attack, List<Attack> attackList);
        void RemoveAttack(Attack atk);

    }

}
