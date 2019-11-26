using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Attack
    {

        private string name;
        private int damage;
        private int cost;
        private string image;


        public Attack(string _name, int _damage, int _cost, string _image)
        {
            this.Name = _name;
            this.Damage = _damage;
            this.Cost = _cost;
            this.Image = _image;
        }

        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Image { get => image; set => image = value; }
    }
}
