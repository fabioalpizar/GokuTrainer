using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Loader
{
    class AttackJSON : ILoader
    {

        public AttackJSON() { }

        public object Load(string file)
        {

            List<Attack> attackList = new List<Attack>();

            string JSONstring = System.IO.File.ReadAllText(file);
            attackJson tempAtks = JsonConvert.DeserializeObject<attackJson>(JSONstring);

            for (int i = 0; i < tempAtks.temp.Count; i++)
            {
                Attack atk = new Attack(tempAtks.temp[i].name, tempAtks.temp[i].damage, tempAtks.temp[i].cost, tempAtks.temp[i].image);
                attackList.Add(atk);
            }

            return attackList;
        }

        public class attackJson
        {
            [JsonProperty("attacks")]
            public IList<tempAtk> temp { get; set; }
        }

        public class tempAtk
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("damage")]
            public int damage { get; set; }
            [JsonProperty("cost")]
            public int cost { get; set; }
            [JsonProperty("imgPaths")]
            public string image { get; set; }
        }

    }
}
