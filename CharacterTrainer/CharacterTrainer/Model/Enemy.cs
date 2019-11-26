using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Enemy : ICharacter
    {

        private string name;
        private int level;
        private int hp;
        private int energy;
        private List<Attack> attacks;
        private List<string> images;

        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Energy { get; set; }
        public List<Attack> Attacks { get; set; }
        public List<string> Images { get; set; }

        public Enemy(string _name, int _level, int _hp, int _energy, List<string> _images)
        {
            this.name = _name;
            this.level = _level;
            this.hp = _hp;
            this.energy = _energy;
            this.images = _images;
        }

        public void AddAttack(string attack, List<Attack> attackList)
        {
            for (int i = 0; i < attackList.Count; i++)
            {
                if (attackList[i].Name.Equals(attack))
                {
                    this.attacks.Add(attackList[i]);
                }
            }
        }

        public void LowerHealth(int damage)
        {
            this.hp = this.hp - damage;
        }

        public void RemoveAttack(Attack atk)
        {
            this.attacks.Remove(atk);
        }

        public void UseAttack(string attack, ICharacter character)
        {
            Attack atk = null;
            for (int i = 0; i < this.attacks.Count(); i++)
            {
                if (this.attacks[i].Name.Equals(attack))
                {
                    atk = attacks[i];
                }
            }

            character.LowerHealth(atk.Damage);
            this.RemoveAttack(atk);

        }
    }
}
