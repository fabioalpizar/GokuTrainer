﻿using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Fight : IActivity
    {
        private Enemy enemy;
        private CharacterFactory enemyFactory = new CharacterFactory();
        private string name = "fight";
        private string log = "";
        private int duration = 3000;


        public Enemy Enemy { get => enemy; set => enemy = value; }
        public string Name { get => name; set => name = value; }
        public string Log { get => log; set => log = value; }
        public int Duration { get => duration; set => duration = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)battle(character);
            return updatedChar;
        }

        private ICharacter battle(ICharacter character)
        {
            this.log = "";
            int charLevel = ((Character)character).Level;
            this.enemy = enemyFactory.getEnemy(charLevel);
            Console.WriteLine(this.Enemy.Images[0]);
            while (battleEnd(character))
            {
                string atk1 = character.UseAttack(this.enemy);
                string atk2 = this.enemy.UseAttack(character);
                this.log += "\n" + atk1 + "\n" + atk2;
                System.Threading.Thread.Sleep(1000);
            }
            return character;
        }

        private Boolean battleEnd(ICharacter character)
        {
            if (this.enemy.Hp < 0 || ((Character)character).Hp < 0)
            {
                Console.WriteLine(won(character));
                this.log += "\n" + won(character);
                return false;
            }
            else if (this.enemy.Energy < 0 || ((Character)character).Energy < 0)
            {
                Console.WriteLine(won(character));
                this.log += "\n" + won(character);
                return false;
            }
            else
            {
                return true;
            }
        }

        private string won(ICharacter character)
        {
            string won;
            if (this.enemy.Hp < ((Character)character).Hp)
            {
                won = "Your Goku character won the fight!";
            }
            else
            {
                won = "Your enemy won the fight, better luck next time!";
            }
            return won;
        }

    }

}
