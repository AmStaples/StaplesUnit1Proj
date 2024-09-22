using System.ComponentModel.DataAnnotations;
namespace StaplesUnit1Proj.Models
{
    public class Wordle
    {
        [Required]
        public string answer { get; set; } = "Water";
        [Required]
        public string input { get; set; } = "";
        [Required]
        public bool slot1status { get; set; } = false; //Status checks are designed to if a letter has been matched to yet.
        [Required]
        public bool slot2status { get; set; } = false;
        [Required]
        public bool slot3status { get; set; } = false;
        [Required]
        public bool slot4status { get; set; } = false;
        [Required]
        public bool slot5status { get; set; } = false;
        [Required]
        public char slot1 { get; set; } = 'a'; //Save individual Characters if need be.
        [Required]
        public char slot2 { get; set; } = 'A';
        [Required]
        public char slot3 { get; set; } = 'a';
        [Required]
        public char slot4 { get; set; } = 'a';
        [Required]
        public char slot5 { get; set; } = 'a';
        //1 for black, 2 for yellow, 3 for green;

        public int CheckSlot(string answer, string input, int slot)
        {
            answer = answer.ToUpper();
            char a = answer[slot];
            char i = input[slot];
            a = char.ToUpper(a);
            i = char.ToUpper(i);
            if (a.Equals(i)) {
                return 3;
            } else if (answer.Contains(i)) {
                return 2;
            } else
            {
                return 1;
            }
        }
    }
}
