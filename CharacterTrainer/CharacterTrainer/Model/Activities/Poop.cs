using CharacterTrainer.Model.Activities;

namespace CharacterTrainer.Model.Rooms
{
    class Poop : IActivity
    {
        private string name = "poop";
        private int duration = 3000;

        public int Duration { get => duration; set => duration = value; }
        public string Name { get => name; set => name = value; }

        public ICharacter ExecuteStrat(ICharacter character)
        {
            Character updatedChar = ((Character)character);
            updatedChar.Hunger -= 30;
            return updatedChar;
        }
    }
}
