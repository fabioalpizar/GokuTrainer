using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTrainer.Model.Activities;
using CharacterTrainer.Model.Rooms;

namespace CharacterTrainer.Controller
{
    class ViewController
    {

        public ViewController()
        {

        }

        public string GetActivity()
        {
            return "walk";
        }

        public void Finish()
        {
            Console.WriteLine("El programa termino");
        }
    }
}
