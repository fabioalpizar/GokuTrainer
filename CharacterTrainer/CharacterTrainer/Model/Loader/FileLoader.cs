using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Loader
{
    class FileLoader
    {

        public AttackJSON atkJSON { get; set; }
        public CharacterJSON charJSON { get; set; }
        public ItemJSON itemJSON { get; set; }
        public EnemyJSON enmyJSON { get; set; }

        FileLoader()
        {
            this.atkJSON = new AttackJSON();
            this.charJSON = new CharacterJSON();
            this.itemJSON = new ItemJSON();
            this.enmyJSON = new EnemyJSON();
        }


        public object loadJSON(string type, string path)
        {
            switch (type)
            {
                case "atk":
                    return this.atkJSON.Load(path);
                case "char":
                    return this.charJSON.Load(path);
                case "enmy":
                    return this.enmyJSON.Load(path);
                case "item":
                    return this.itemJSON.Load(path);
                default:
                    Console.WriteLine("ERROR: object type not defined, could not load JSON properly");
                    return null;
            }
        }


    }
}
