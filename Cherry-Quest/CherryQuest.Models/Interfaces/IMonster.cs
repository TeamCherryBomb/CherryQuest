namespace CherryQuest.Models.Interfaces
{
    using Enums;
    using Microsoft.Xna.Framework;

    public interface IMonster : IDrawableGameObject, IMovable
    {
        int X { get; set; }

        int Y { get; set; }

        Rectangle BoundingBox { get;}

        int Health { get; set; }

        int Attack { get; set; }

        int Defence { get; set; }
    }
}
