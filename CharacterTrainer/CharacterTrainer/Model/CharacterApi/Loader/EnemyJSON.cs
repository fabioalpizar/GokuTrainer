using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Loader
{
    class EnemyJSON : ILoader
    {

        List<Attack> attackList;

        public EnemyJSON()
        {
            AttackJSON tempAttackJson = new AttackJSON();
            this.attackList = (List<Attack>)tempAttackJson.Load("Resources/jsons/attacks.json");
        }

        public object Load(string file)
        {

            List<ICharacter> EnemyList = new List<ICharacter>();

            string JSONstring = System.IO.File.ReadAllText(file);
            List<tempEnemy> tempEnemyList = JsonConvert.DeserializeObject<List<tempEnemy>>(JSONstring);

            for (int i = 0; i < tempEnemyList.Count; i++)
            {
                Enemy e = new Enemy(tempEnemyList[i].name, tempEnemyList[i].level, tempEnemyList[i].hp, tempEnemyList[i].energy, tempEnemyList[i].images);
                for (int k = 0; k < tempEnemyList[i].attacks.Count; k++)
                {
                    e.AddAttack(tempEnemyList[i].attacks[k], this.attackList);
                }

                EnemyList.Add(e);
            }

            return EnemyList;
        }

        class tempEnemy
        {

            public string name;
            public int level, hp, energy;
            public List<string> attacks, images;

        }

    }
}
