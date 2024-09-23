using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
namespace StaplesUnit1Proj.Models
{
    public class Wordle
    {
        [Required]
        public string answer { get; set; } = "Water";
        [Required]
        public string input { get; set; } = "";
        [Required]
        public int slot1status { get; set; } = 1; //Status checks are designed to if a letter has been matched to yet.
        [Required]
        public int slot2status { get; set; } = 1;
        [Required]
        public int slot3status { get; set; } = 1;
        [Required]
        public int slot4status { get; set; } = 1;
        [Required]
        public int slot5status { get; set; } = 1; //1 for no match, 2 for matching a different slot, 3 for matching;
        [Required]
        public bool slot1 { get; set; } = false; //yes no if a slot has 
        [Required]
        public bool slot2 { get; set; } = false;
        [Required]
        public bool slot3 { get; set; } = false;
        [Required]
        public bool slot4 { get; set; } = false;
        [Required]
        public bool slot5 { get; set; } = false;


        public void CheckSlot(string answer, string input)
        {
            int slot = 0;
            answer = answer.ToUpper();
            input = input.ToUpper();
            while (slot <= 4)
            {
                char a = answer[slot];
                char i = input[slot];
                if (a.Equals(i))
                {
                    Switch(slot, 3); //Set matching letter to green
                } else if (answer.Contains(i)) //Code will not run past here if letter is matched. 
                {
                    foreach (char c in answer)
                    {
                        //if
                    }
                }

                slot++;
            }
            //Check each to each 1 - 1, 2-2
            //Check each other slot IF still valid. If valid then also check if valid on receiver
            //Default to black.
            //Check First then switch validities then check yellows using validity;
        }
        public void Switch(int slot, int value)
        {
            if (value == 3)
            {
                switch (slot)
                {
                    case 0: slot1status = 3; break;
                    case 1: slot2status = 3; break;
                    case 2: slot3status = 3; break;
                    case 3: slot4status = 3; break;
                    case 4: slot5status = 3; break;
                }
            }
            else if (value == 2)
            {
                switch (slot)
                {
                    case 0: slot1status = 2; break;
                    case 1: slot2status = 2; break;
                    case 2: slot3status = 2; break;
                    case 3: slot4status = 2; break;
                    case 4: slot5status = 2; break;
                }
            }
            else if (value == 1)
            {
                switch (slot)
                {
                    case 0: slot1status = 1; break;
                    case 1: slot2status = 1; break;
                    case 2: slot3status = 1; break;
                    case 3: slot4status = 1; break;
                    case 4: slot5status = 1; break;
                }
            }
        }
    }  
}
