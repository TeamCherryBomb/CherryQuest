namespace CherryQuest.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;

    public class Path
    {
        private ICollection<Point> points;

        public Path()
        {
            this.points = new HashSet<Point>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Point> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}