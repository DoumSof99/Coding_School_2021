using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Answers {
    class Answers1Class {

        public void Recursion() {

            int decimalNumber;

            Console.WriteLine("\nConvert a decimal number to binary using recursion :");

            Console.Write("\nWrite a decimal number: ");
            decimalNumber = int.Parse(Console.ReadLine());

            Console.Write("\nThe decimal is {0} and the binary: ", decimalNumber);

            ConvertDecimalToBinary(decimalNumber);
        }

        public int ConvertDecimalToBinary(int number) {

            int toBinary;

            if (number != 0) {
                toBinary = (int)((number % 2) + 10 * ConvertDecimalToBinary(number / 2));
                Console.Write(toBinary);
                return 0;
            }
            else {
                return 0;
            }
        }

    }
}
