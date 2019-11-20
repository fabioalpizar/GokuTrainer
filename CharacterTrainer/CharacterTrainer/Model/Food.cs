using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Food : IConsumable
    {

        private string Name { get; set; }
        private int Points { get; set; }

        public Food(string _name, int _points)
        {
            this.Name= _name;
            this.Points = _points;
        }

        public int Consume(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
