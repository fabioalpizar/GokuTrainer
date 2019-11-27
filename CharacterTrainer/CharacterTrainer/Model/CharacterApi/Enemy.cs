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

        public Enemy(string _name, int _level, int _hp, int _energy, List<string> _images)
        {
            this.Name = _name;
            this.Level = _level;
            this.Hp = _hp;
            this.Energy = _energy;
            this.Images = _images;
            this.Attacks = new List<Attack>();
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Energy { get => energy; set => energy = value; }
        public List<string> Images { get => images; set => images = value; }
        internal List<Attack> Attacks { get => attacks; set => attacks = value; }

        public void AddAttack(string attack, List<Attack> attackList)
        {
            for (int i = 0; i < attackList.Count; i++)
            {
                if (attackList[i].Name.Equals(attack))
                {
                    this.Attacks.Add(attackList[i]);
                }
            }
        }

        public string LowerHealth(int damage)
        {
            this.Hp = this.Hp - damage;
            return this.Name + " took " + damage.ToString() + " damage.";
        }

        public void RemoveAttack(Attack atk)
        {
            this.Attacks.Remove(atk);
        }

        public string UseAttack(ICharacter character)
        {
            var rand = new Random();
            int i = rand.Next(this.attacks.Count);
            Attack atk = this.attacks[i];
            character.LowerHealth(atk.Damage);
            Console.WriteLine(atk.Name + " used.");
            //this.RemoveAttack(atk);
            return this.Name + " used " + atk.Name;
        }
    }
}
