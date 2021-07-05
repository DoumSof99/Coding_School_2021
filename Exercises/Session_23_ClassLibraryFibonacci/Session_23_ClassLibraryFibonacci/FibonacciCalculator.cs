using System;

namespace Session_23_ClassLibraryFibonacci {
    public class FibonacciCalculator : IFibonacciCalculator{

        //public long CalculateFibonacciNumber(long num) {

        //    // Question A
        //    if (num == 0) {
        //        return 0;
        //    }

        //    // Question B
        //    if (num == 1) {
        //        return 1;
        //    }

        //    // Question D
        //    if (num < 0) {
        //        throw new ArgumentException("Invalid Input", nameof(num));
        //    }

        //    // Question E
        //    if (num >= 90) {
        //        throw new ArgumentException("Fibonacci result number too big", nameof(num));
        //    }

        //    // Question C
        //    long firstNum = 0;
        //    long secondNum = 1;
        //    long result = 0;

        //    for (int i = 2; i <= num; i++) {
        //        result = firstNum + secondNum;
        //        firstNum = secondNum;
        //        secondNum = result;
        //    }
        //    return result;
        //}

        public long FibonacciSerries(long n) {
            // Question A
            if (n == 0) {
                return 0;
            }

            // Question B
            if (n == 1) {
                return 1;
            }

            // Question D
            if (n < 0) {
                throw new ArgumentException("Invalid Input", nameof(n));
            }

            // Question E
            if (n >= 90) {
                throw new ArgumentException("Fibonacci result number too big", nameof(n));
            }

            // Question C
            long firstNum = 0;
            long secondNum = 1;
            long result = 0;

            for (int i = 2; i <= n; i++) {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
            }
            return result;
        }
    }
}
