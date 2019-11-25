using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Character : ICharacter
    {

        private string name;
        private int level;
        private int speed;
        private int hp;
        private int happiness;
        private int energy;
        private int thirst;
        private int hunger;
        private string condition;
        private List<Attack> attacks;
        private List<string> images;

        public Character(string _name, int _level, int _speed, int _hp, int _happiness, int _energy, int _thirst, int _hunger, string _condition, List<Attack> _attacks, List<string> _images)
        {
            this.name = _name;
            this.level = _level;
            this.speed = _speed;
            this.hp = _hp;
            this.happiness = _happiness;
            this.energy = _energy;
            this.thirst = _thirst;
            this.hunger = _hunger;
            this.condition = _condition;
            this.attacks = _attacks;
            this.images = _images;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Speed { get; set; }
        public int Hp { get; set; }
        public int Happiness { get; set; }
        public int Energy { get; set; }
        public int Thirst { get; set; }
        public int Hunger { get; set; }
        public string Condition { get; set; }
        public List<string> Images { get; set; }

        public void AddAttack(string attack, List<Attack> attackList)
        {
            for (int i = 0; i < attackList.Count; i++)
            {
                if (true)
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
            this.energy = this.energy - atk.Cost;
            this.RemoveAttack(atk);

        }
    }
}
