using CharacterTrainer.Model.CharacterApi.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Conditions
{
    class ConditionController
    {
        private List<ICondition> conditionList;

        public List<ICondition> ConditionList { get => conditionList; set => conditionList = value; }

        public ConditionController()
        {
            this.conditionList = new List<ICondition>();

            this.conditionList.Add(new Sick());
            this.conditionList.Add(new Tired());
            this.conditionList.Add(new Fat());
            this.conditionList.Add(new Beatup());

        }

        public ICharacter executeCondition(string condition, ICharacter Character)
        {
            ICharacter updatedChar;
            updatedChar = findCondition(condition).ExecuteStrat(Character);
            return updatedChar;
        }

        public ICondition findCondition(string condition)
        {
            ICondition requested = null;
            for (int i = 0; i < this.conditionList.Count; i++)
            {
                if (this.conditionList[i].Name.Equals(condition))
                {
                    requested = this.conditionList[i];
                }
            }
            return requested;
        }
    }
}
