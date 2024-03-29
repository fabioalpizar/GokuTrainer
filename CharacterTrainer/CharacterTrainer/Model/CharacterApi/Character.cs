﻿using System;
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
        private List<IConsumable> items;
        private List<Attack> attacks;
        private List<string> images;

        public Character(string _name, int _level, int _speed, int _hp, int _happiness, int _energy, int _thirst, int _hunger, string _condition, List<string> _images)
        {
            this.Name = _name;
            this.Level = _level;
            this.Speed = _speed;
            this.Hp = _hp;
            this.Happiness = _happiness;
            this.Energy = _energy;
            this.Thirst = _thirst;
            this.Hunger = _hunger;
            this.Condition = _condition;
            this.Items = new List<IConsumable>();
            this.Attacks = new List<Attack>();
            this.Images = _images;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Thirst { get => thirst; set => thirst = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public string Condition { get => condition; set => condition = value; }
        public List<string> Images { get => images; set => images = value; }
        internal List<IConsumable> Items { get => items; set => items = value; }
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

        public void AddAttack(Attack atk)
        {
            this.Attacks.Add(atk);
        }

        public void AddItem(IConsumable item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IConsumable item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].Name.Equals(item.Name))
                {
                    this.Items.RemoveAt(i);
                }
            }
        }

        public void AddItem(string item, List<IConsumable> itemList)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].Name.Equals(item))
                {
                    this.Items.Add(itemList[i]);
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
            string battleData = "";
            var rand = new Random();
            int i = rand.Next(this.attacks.Count);
            Attack atk = this.attacks[i];
            battleData += character.LowerHealth(atk.Damage);
            battleData += "\n" + this.Name + " used " + atk.Name;
            //this.RemoveAttack(atk);
            return battleData;
        }

        public void LevelUp()
        {
            this.Level = Level + 1;
            this.Speed = Speed + 1;
            this.Hp = Hp + 1;
            this.Happiness = Happiness + 1;
            this.Energy = Energy + 1;
        }

    }
}
