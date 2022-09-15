using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelSolution.Business_Layer
{
    internal class Validation
    {
        //Data Member
        private static string title = "Entry Error";

        //Property
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        //Validation
        public static bool PhoneValidate(TextBox textBox)
        {
            int number = 0;
            if (int.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Your phone number is invalid. Please try again.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool ValidateString(string string1)
        {
            //Look for invalid characters
            List<string> invalidChars = new List<string>() { "+" , "!", "@", "#", "$", "%", "^", "&",
                                                             "*", "(", ")", "-", "_" , "=" , "[" , "]" 
                                                             , "`" , "~" , ";" , ":", "'", "<" , ">" , 
                                                            "," , "/" , "?" , "|" , ".", "1", "2", "3",
                                                            "4", "5", "6", "7", "8", "9", "0" };


            foreach (string s in invalidChars)
            {
                if (string1.Contains(s))
                {
                    MessageBox.Show("Your Name contains invalid characters. Please try again.", Title);
                    return false;

                }
            }
            return true;
        }

    }
}
