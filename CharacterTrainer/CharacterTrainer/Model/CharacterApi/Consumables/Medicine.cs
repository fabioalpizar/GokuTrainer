using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class Medicine : IConsumable
    {
        private string name;
        private List<int> points;
        private string image;

        public Medicine(string _name, List<int> _points, string _image)
        {
            this.Name = _name;
            this.Points = _points;
            this.Image = _image;
        }

        public string Name { get => name; set => name = value; }
        public List<int> Points { get => points; set => points = value; }
        public string Image { get => image; set => image = value; }

        public ICharacter Consume(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Energy += this.points[0];
            updatedChar.Hp += this.points[1];
            updatedChar.Hunger += this.points[2];
            updatedChar.Thirst += this.points[3];
            return updatedChar;
        }

    }
}
