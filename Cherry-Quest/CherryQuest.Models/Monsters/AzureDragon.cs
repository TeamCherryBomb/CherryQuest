namespace CherryQuest.Models.Monsters
{
    using Models;

    public class AzureDragon : Monster
    {
        private const int AzureHealth = 250;
        private const int AzureAttack = 60;
        private const int AzureDefence = 40;

        public AzureDragon(string name, Position position, bool isAlive)
            : base(name, position, AzureHealth, AzureAttack, AzureDefence, isAlive)
        {
        }
    }
}
