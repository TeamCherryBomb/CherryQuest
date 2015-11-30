using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryQuest.Models
{
    using System.ComponentModel.DataAnnotations;
    using Enums;

    public class Player
    {
        private ICollection<Monster> monsters;

        public Player()
        {
            this.monsters = new HashSet<Monster>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public PlayerType PlayerType { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Monster> Monsters
        {
            get { return this.monsters; }
            set { this.monsters = value; }
        }

    }
}
