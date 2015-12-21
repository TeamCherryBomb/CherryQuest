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

        int Health { get; }

        Rectangle BoundingBox { get; }

        CharacterLevel Level { get; }

        int Gold { get; }

        void IncreaseGold(int value);

        IEnumerable<Monster> Monsters { get; }

        void DealDamage(IMonster monster);

        void RespondToAttack(int damage, GameTime gameTime);

    }
}
