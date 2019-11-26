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

        public FileLoader()
        {
            this.atkJSON = new AttackJSON();
            this.charJSON = new CharacterJSON();
            this.itemJSON = new ItemJSON();
            this.enmyJSON = new EnemyJSON();
        }


        public object loadJSON(string type)
        {
            switch (type)
            {
                case "atk":
                    return this.atkJSON.Load(@"Resources\jsons\attacks.json");
                case "char":
                    return this.charJSON.Load(@"Resources\jsons\new.json");
                case "enmy":
                    return this.enmyJSON.Load(@"Resources\jsons\enemies.json");
                case "item":
                    return this.itemJSON.Load(@"Resources\jsons\items.json");
                default:
                    Console.WriteLine("ERROR: object type not defined, could not load JSON properly");
                    return null;
            }
        }


    }
}
