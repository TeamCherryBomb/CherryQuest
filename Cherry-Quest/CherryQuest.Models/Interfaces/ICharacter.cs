namespace CherryQuest.Models.Interfaces
{
    using System.Collections.Generic;
    using Characters;
    using Monsters;

    public interface ICharacter : IMovable
    {
        int Attack { get; set; }

        int Defence { get; set; }

        CharacterLevel Level { get; set; }

        int Gold { get; set; }

        IEnumerable<Monster> Monsters { get; }
    }
}
