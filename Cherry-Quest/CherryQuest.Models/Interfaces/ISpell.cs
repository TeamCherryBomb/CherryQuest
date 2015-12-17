namespace CherryQuest.Models.Interfaces
{
    using Microsoft.Xna.Framework;

    public interface ISpell : IDrawableGameObject, IMovable
    {

        int X { get; set; }

        int Y { get; set; }

        Rectangle BoundingBox { get; }

        void Dispose();
    }
}