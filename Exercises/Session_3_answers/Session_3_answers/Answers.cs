using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_answers {
    public class Answers {

        //-------------Question1----------------------
        public string LongestWord(string line) {
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";

            int i = 0;

            foreach (String s in words) {
                if (s.Length > i) {

                    word = s;
                    i = s.Length;
                }
            }
            return word;
        }
        //-------------Question2----------------------

        public string ReverseWord(string userInput) {
            char[] inArray = userInput.ToCharArray();
            Array.Reverse(inArray);
            return new string(inArray);
        }

        //-------------Question5----------------------
        public void SortTheArray() {
            int[] array = new int[10] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Array.Sort(array);

            foreach (int item in array) {
                Console.WriteLine(" {0} ", item);
            }

        }

    }
}
 



