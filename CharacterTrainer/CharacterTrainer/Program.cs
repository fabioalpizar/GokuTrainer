using CharacterTrainer.Controller;
using CharacterTrainer.Model;
using CharacterTrainer.Model.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterTrainer
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewController v = new ViewController();
            new GameLogic(20, 3, v);
            Application.Run(v.GameForm);
            //new GameLogic(3, 5);
            //CharacterFactory f = new CharacterFactory();
            //List<IConsumable> items = f.Items;
            //Console.WriteLine("" + items[0].Points[0]);
        }

        

    }
}
