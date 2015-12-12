namespace CherryQuest.Models.Characters
{
    using Models;

    public class Ranger : Character
    {
        public Ranger(string name, Position position, int attack, int defence, CharacterLevel level, int gold) 
            : base(name, position, attack, defence, level, gold)
        {
        }
    }
}
