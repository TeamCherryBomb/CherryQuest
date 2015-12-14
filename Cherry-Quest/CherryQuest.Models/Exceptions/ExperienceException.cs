namespace CherryQuest.Models.Exceptions
{
    using System;

    public class ExperienceException : ArgumentException
    {
        private const string DefaultMessage = "Experience gained must be non-negative";

        public ExperienceException()
            : base(DefaultMessage)
        {
        }
    }
}
