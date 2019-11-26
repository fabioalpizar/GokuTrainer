using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Loader
{
    class CharacterJSON : ILoader
    {

        List<IConsumable> itemList;
        List<Attack> attackList;

        public CharacterJSON()
        {
            ItemJSON tempItemJson = new ItemJSON();
            AttackJSON tempAttackJson = new AttackJSON();
            this.itemList = (List<IConsumable>)tempItemJson.Load(@"Resources\jsons\items.json");
            this.attackList = (List<Attack>)tempAttackJson.Load(@"Resources\jsons\attacks.json");
        }

        public object Load(string file)
        {
            string JSONstring = System.IO.File.ReadAllText(file);

            tempChar newChar = JsonConvert.DeserializeObject<tempChar>(JSONstring);
            Character completeChar = new Character(newChar.name, newChar.level, newChar.speed, newChar.hp, newChar.happiness, newChar.energy, newChar.thirst, newChar.hunger, newChar.condition, newChar.imgPaths);

            for (int i = 0; i < newChar.items.Count; i++)
            {
                completeChar.AddItem(newChar.items[i], this.itemList);
            }
            for (int i = 0; i < newChar.attacks.Count; i++)
            {
                completeChar.AddAttack(newChar.attacks[i], this.attackList);
            }

            return completeChar;
        }


        public class tempChar
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("level")]
            public int level { get; set; }
            [JsonProperty("speed")]
            public int speed { get; set; }
            [JsonProperty("hp")]
            public int hp { get; set; }
            [JsonProperty("happiness")]
            public int happiness { get; set; }
            [JsonProperty("energy")]
            public int energy { get; set; }
            [JsonProperty("thirst")]
            public int thirst { get; set; }
            [JsonProperty("hunger")]
            public int hunger { get; set; }
            [JsonProperty("condition")]
            public string condition { get; set; }
            [JsonProperty("attacks")]
            public List<string> attacks { get; set; }
            [JsonProperty("items")]
            public List<string> items { get; set; }
            [JsonProperty("imgPaths")]
            public List<string> imgPaths { get; set; }
        }
    }
}
