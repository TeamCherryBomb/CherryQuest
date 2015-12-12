namespace CherryQuest.Models
{
    public abstract class GameObject
    {
        protected GameObject(Position position, string name)
        {
            this.Position = position;
            this.Name = name;
        }

        public Position Position { get; set; }

        public string Name { get; set; }

    }
}
