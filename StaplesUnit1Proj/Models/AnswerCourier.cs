using System.ComponentModel.DataAnnotations;

namespace StaplesUnit1Proj.Models
{
    public class AnswerCourier
    {
        [Required]
        [StringLength(5),MinLength(5)]
        public string answer { get; set; }
    }
}
