namespace CherryQuest.Models.Interfaces
{
    using System.Collections.Generic;
    using Characters;
    using Microsoft.Xna.Framework;
    using Monsters;

    public interface ICharacter : IDrawableGameObject, IMovable
    {
        int Attack { get; set; }

        int Defence { get; set; }

        Rectangle BoundingBox { get; }

        CharacterLevel Level { get; set; }

        int Gold { get; set; }

        IEnumerable<Monster> Monsters { get; }

        void TakeDemage(IMonster monster);

    }
}
