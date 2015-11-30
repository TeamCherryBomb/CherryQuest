namespace CherryQuest.Models
{
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class Monster
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public MonsterType MonsterType { get; set; }

        public int AttackPoints { get; set; }

        public int HelathPoints { get; set; }

        public int DefensePoints { get; set; }

        public int MageResistence { get; set; }

        public int OwnerId { get; set; }

        public virtual Player Owner { get; set; }
    }
}