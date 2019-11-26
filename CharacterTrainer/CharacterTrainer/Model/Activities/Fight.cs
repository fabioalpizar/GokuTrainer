using CharacterTrainer.Model.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Rooms
{
    class Fight : IStrategy
    {
        private Enemy enemy;

        public Enemy Enemy { get => enemy; set => enemy = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = (Character)battle(character);
            return updatedChar;
        }

        private ICharacter battle(ICharacter character)
        {
            while (battleEnd(character))
            {
                character.UseAttack(this.enemy);
                this.enemy.UseAttack(character);
                System.Threading.Thread.Sleep(3000);
            }
            return character;
        }

        private Boolean battleEnd(ICharacter character)
        {
            if (this.enemy.Hp < 0 || ((Character)character).Hp < 0)
            {
                Console.WriteLine(won(character));
                return false;
            }
            else if (this.enemy.Energy < 0 || ((Character)character).Energy < 0)
            {
                Console.WriteLine(won(character));
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
