using CharacterTrainer.Model.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class CharacterFactory
    {

        private ICharacter newCharacter;
        private List<ICharacter> enemies;
        private List<IConsumable> items;
        private List<Attack> attacks;

        public CharacterFactory()
        {
            FileLoader fileLoader = new FileLoader();

            this.Items = (List<IConsumable>)fileLoader.loadJSON("item");
            this.Attacks = (List<Attack>)fileLoader.loadJSON("atk");
            this.NewCharacter = (ICharacter)fileLoader.loadJSON("char");
            this.Enemies = (List<ICharacter>)fileLoader.loadJSON("enmy");
        }

        public ICharacter NewCharacter { get => newCharacter; set => newCharacter = value; }
        public List<ICharacter> Enemies { get => enemies; set => enemies = value; }
        public List<IConsumable> Items { get => items; set => items = value; }
        public List<Attack> Attacks { get => attacks; set => attacks = value; }

        public Character getNewCharacter()
        {
            return (Character)this.newCharacter;
        }

        public IConsumable getItem(string item)
        {
            for (int i = 0; i < this.attacks.Count; i++)
            {
                if (this.items[i].Name.Equals(item))
                {
                    return this.items[i];
                }
            }
            return null;
        }

        public IConsumable getRandomItem()
        {
            var rand = new Random();
            int i = rand.Next(this.items.Count);
            return this.items[i];
        }

        public Attack getAttack(string atk)
        {
            for (int i = 0; i < this.attacks.Count; i++)
            {
                if (this.attacks[i].Name.Equals(atk))
                {
                    return this.attacks[i];
                }
            }
            return null;
        }

        public Enemy getEnemy(int level)
        {
            for (int i = 0; i < this.enemies.Count; i++)
            {
                if (((Enemy)this.enemies[i]).Level.Equals(level))
                {
                    return (Enemy)this.enemies[i];
                }
            }
            return (Enemy)this.enemies[this.enemies.Count - 1];
        }


    }

     

}
