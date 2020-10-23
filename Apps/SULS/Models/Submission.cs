using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SULS.Models
{
    public class Submission
    {
        public Submission()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(800)]
        public string Code { get; set; }

        public int AchievedResult { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual Problem Problem { get; set; }

        public virtual User User { get; set; }
    }
}
