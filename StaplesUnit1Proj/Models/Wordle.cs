using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
namespace StaplesUnit1Proj.Models
{
    public class Wordle
    {
        [Required]
        public string input { get; set; }
        [Required]
        public int slot1status { get; set; } = 1; //Status checks are designed to if a letter has been matched to yet.
        [Required]
        public int slot2status { get; set; } = 1;
        [Required]
        public int slot3status { get; set; } = 1; //Matching to the input slot not the Answer key
        [Required]
        public int slot4status { get; set; } = 1;
        [Required]
        public int slot5status { get; set; } = 1; //1 for no match, 2 for matching a different slot, 3 for matching;
        [Required]
        public bool s1used { get; set; }
        [Required]
        public bool s2used { get; set; }
        [Required]
        public bool s3used { get; set; }
        [Required]
        public bool s4used {  get; set; }
        [Required]
        public bool s5used { get; set; }


        public void CheckSlot(string answer)
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
                    Switcher(slot, 3); //Set matching letter to green
                }
                else if (answer.Contains(i)) //Code will not run past here if letter is matched. 
                {
                    int index = answer.IndexOf(i);
                    //Check that the index, status and if the slot has already been used this check before establishing a value
                    if (index == 0 && slot1status == 1 && s1used == false) { Switcher(slot, 2); s1used = true; }
                    else if (index == 1 && slot2status == 1 && s2used == false) { Switcher(slot, 2); s2used = true; }
                    else if (index == 2 && slot3status == 1 && s3used == false) { Switcher(slot, 2); s3used = true; }
                    else if (index == 3 && slot4status == 1 && s4used == false) { Switcher(slot, 2); s4used = true; }
                    else if (index == 4 && slot5status == 1 && s5used == false) { Switcher(slot, 2); s5used = true; }
                } 
                else 
                { Switcher(slot, 1); }

                slot++;
            }
            s1used = false;//Reset for the next word check
            s2used = false;
            s3used = false;
            s4used = false;
            s5used = false;
            //Check each to each 1 - 1, 2-2
            //Check each other slot IF still valid. If valid then also check if valid on receiver
            //Default to black.
            //Check First then switch validities then check yellows using validity;
        }
        public void Switcher(int slot, int value)
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
