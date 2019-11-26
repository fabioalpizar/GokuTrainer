using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Loader
{
    class ItemJSON : ILoader
    {

        public ItemJSON() { }

        public object Load(string file)
        {
            List<IConsumable> ConsumableList = new List<IConsumable>();

            string JSONstring = System.IO.File.ReadAllText(file);
            itemJson tempItems = JsonConvert.DeserializeObject<itemJson>(JSONstring);

            for (int i = 0; i < tempItems.temp.Count; i++)
            {
                if(tempItems.temp[i].type.Equals("food"))
                {
                    Food f = new Food(tempItems.temp[i].name, tempItems.temp[i].points, tempItems.temp[i].image);
                    ConsumableList.Add(f);
                }
                else
                {
                    ConsumableList.Add(new Medicine(tempItems.temp[i].name, tempItems.temp[i].points, tempItems.temp[i].image));
                }
            }

            return ConsumableList;

        }

        public class itemJson
        {
            [JsonProperty("items")]
            public IList<tempItem> temp { get; set; }
        }

        public class tempItem
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("type")]
            public string type { get; set; }
            [JsonProperty("points")]
            public List<int> points { get; set; }
            [JsonProperty("imgPaths")]
            public string image { get; set; }
        }


    }
}
