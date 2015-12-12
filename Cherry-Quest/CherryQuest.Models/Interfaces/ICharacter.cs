namespace TW.Interfaces
{
    using System.Collections.Generic;
    using Characters;
    using Monsters;

    public interface ICharacter
    {
        string Name { get; set; }

        Position Position { get; set; }

        int Attack { get; set; }

        int Defence { get; set; }

        CharacterLevel Level { get; set; }

        int Gold { get; set; }

        ICollection<Monster> Monsters { get; set; }
    }
}
