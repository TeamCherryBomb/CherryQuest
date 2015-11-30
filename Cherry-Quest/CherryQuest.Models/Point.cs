namespace CherryQuest.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Point
    {
        [Key]
        public int Id { get; set; }

        public float X { get; set; }

        public float Y { get; set; }
    }
}