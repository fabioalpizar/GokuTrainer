using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Medicine : IMedicine
    {
        private string name;
        private List<int> points;
        private string image;

        public string Name { get; set; }
        public List<int> Points { get; set; }
        public int Image { get; set; }

        public Food(string _name, List<int> _points, string _image)
        {
            this.name = _name;
            this.points = _points;
            this.image = _image;
        }

        void IConsumable.Consume(ICharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
