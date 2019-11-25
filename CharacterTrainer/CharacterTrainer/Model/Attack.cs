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

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Cost { get; set; }
        public string Image { get; set; }

        public Attack(string _name, int _damage, int _cost, string _image)
        {
            this.name = _name;
            this.damage = _damage;
            this.cost = _cost;
            this.image = _image;
        }


    }
}
