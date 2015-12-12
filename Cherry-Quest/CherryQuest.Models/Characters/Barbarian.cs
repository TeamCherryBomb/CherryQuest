namespace TW.Characters
{
    public class Barbarian : Character
    {
        public Barbarian(int id, string name, Position position, int attack, int defence, CharacterLevel level, int gold) 
            : base(id, name, position, attack, defence, level, gold)
        {
        }
    }
}
