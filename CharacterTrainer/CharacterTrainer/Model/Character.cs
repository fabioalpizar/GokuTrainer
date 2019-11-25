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
        private List<string> images;

        public Character()
        {

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

        public void AddAttack(string attack) { }

        public void LowerHealth(int damage)
        {
            this.hp = this.hp - damage;
        }

        public void UseAttack(string attack, ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
