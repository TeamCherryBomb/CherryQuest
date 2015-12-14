namespace CherryQuest.Models.Exceptions
{
    using System;

    public class UnknownCharacterClassException : NotSupportedException
    {
        private const string DefaultMessage = "The required character class is currently not implemented";

        public UnknownCharacterClassException()
            : base(DefaultMessage)
        {
        }
    }
}
