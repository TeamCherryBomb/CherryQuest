namespace CherryQuest.Models.Characters
{
    using Exceptions;

    public class CharacterLevel
    {
        private const int DefaultStartLevel = 0;
        private const int DefaultStartExperience = 0;

        public CharacterLevel() 
            : this(DefaultStartExperience, DefaultStartLevel)
        {
        }

        private CharacterLevel(int exp, int level)
        {
            this.Experience = exp;
            this.Value = level;
        }
 
        public int Experience { get; private set; }

        public int Value { get; private set; }

        public void IncreaseLevel()
        {
            this.Value++;
        }

        public void IncreaseExperience(int value)
        {
            if (value < 0)
            {
                throw new ExperienceException();
            }

            this.Experience += value;
        }
    }
}
