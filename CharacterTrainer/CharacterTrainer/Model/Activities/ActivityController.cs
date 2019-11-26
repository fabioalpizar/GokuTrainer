using CharacterTrainer.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model.Activities
{
    class ActivityController
    {

        private IActivity currentActivity;
        private List<IActivity> activityList;

        public IActivity CurrentActivity { get => currentActivity; set => currentActivity = value; }
        public List<IActivity> ActivityList { get => activityList; set => activityList = value; }

        public ActivityController()
        {
            this.currentActivity = null;
            this.activityList = new List<IActivity>();

            this.activityList.Add(new Consume());
            this.activityList.Add(new Farm());
            this.activityList.Add(new Fight());
            this.activityList.Add(new Friends());
            this.activityList.Add(new Meditate());
            this.activityList.Add(new Pee());
            this.activityList.Add(new Poop());
            this.activityList.Add(new Run());
            this.activityList.Add(new Sleep());
            this.activityList.Add(new Spar());
            this.activityList.Add(new Walk());

        }

        public ICharacter executeActivity(string activity, ICharacter Character)
        {
            ICharacter updatedChar;
            switch (activity)
            {
                case "fight":
                    Fight fight = (Fight)findActivity(activity);
                    startCurrentAcitity(fight);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "friends":
                    Friends friends = (Friends)findActivity(activity);
                    startCurrentAcitity(friends);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "meditate":
                    Meditate meditate = (Meditate)findActivity(activity);
                    startCurrentAcitity(meditate);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "pee":
                    Pee pee = (Pee)findActivity(activity);
                    startCurrentAcitity(pee);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "poop":
                    Poop poop = (Poop)findActivity(activity);
                    startCurrentAcitity(poop);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "run":
                    Run run = (Run)findActivity(activity);
                    startCurrentAcitity(run);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "sleep":
                    Sleep sleep = (Sleep)findActivity(activity);
                    startCurrentAcitity(sleep);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                case "spar":
                    Spar spar = (Spar)findActivity(activity);
                    startCurrentAcitity(spar);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                default:
                    Walk walk = (Walk)findActivity(activity);
                    startCurrentAcitity(walk);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
            }
            return updatedChar;
        }


        public ICharacter executeActivity(string activity, ICharacter Character, IConsumable item)
        {
            ICharacter updatedChar;
            switch (activity)
            {
                case "consume":
                    Consume c = (Consume)findActivity(activity);
                    c.Item = item;
                    startCurrentAcitity(c);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
                default:
                    Farm f = (Farm)findActivity(activity);
                    f.Item = item;
                    startCurrentAcitity(f);
                    updatedChar = this.currentActivity.ExecuteStrat(Character);
                    break;
            }
            return updatedChar;
        }

        public IActivity findActivity(string activity)
        {
            IActivity requested = null;
            for (int i = 0; i < this.activityList.Count; i++)
            {
                if (this.activityList[i].Name.Equals(activity))
                {
                    requested = this.activityList[i];
                }
            }
            return requested;
        }

        private void startCurrentAcitity(IActivity activity)
        {
            this.currentActivity = activity;
        }

        private void endCurrentAcitity()
        {
            this.currentActivity = null;
        }

    }
}
