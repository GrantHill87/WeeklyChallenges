using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();

            //var sum = 0;
            //foreach (var num in numbers) //perhaps this method of coding is more readable than the linq format.
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num; //if num is even, add num.
            //    }
            //    if (num % 2 != 0)
            //    {
            //        sum -= num; ..if num is odd, subtract odd.
            //    }
            //}
            //return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4) //does expressing multiple paramters of the same type mean that the method wants a return in the form of a list?
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min(); //simpler way to make a checker, that looks for shortest strings in a set of parameters.
        } //if I didn't use this method here for this function, i might try if else statements, which would be lengthier to read.
          // if (str1 < str2 && str1 < str3 && str1 < str4)
          //{
          //  return str1
          //}
          // if (str2 < str1 && str2 < str3 && str2 < str4)
          //{
          //  return str2
          //}
          // if (str3 < str2 && str3 < str1 && str3 < str4)
          //{
          //  return str3
          //}
          // if (str4 < str2 && str4 < str3 && str4 < str1)
          //{
          //  return str4
          //}
          //return null;
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var smallest = number1;
            var list = new List<int>() {number1, number2, number3, number4 };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz) //be sure to take a look at the class first, see what's going on, and that will help determine how we write the code here.
        {
            biz.Name = "TrueCoders"; //we don't have to return this because this line of code is being written within a method that is expecting a void return type, or nothing to be returned.
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3) //what makes a triangle? The sum of two sides should always be greater than the third side....
        { //if two sides were equal to lesser than the third side, a triangle formation would not be possible; the result would be a straight line that is shorter than the third line.
            return ( //so if we create variables that illustrate this principle, and implement them in a very logical manner, with the right syntax, we can tell the computer how to create
                  sideLength1 + sideLength2 > sideLength3 && //the basis for triangular creation. Using a bool here is tempting, but not necessary.
                  sideLength1 + sideLength3 > sideLength2 &&
                  sideLength2 + sideLength3 > sideLength1
                  );
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length; //objs is an 'object' based list.
            var majority = (amount / 2) + 1;

            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0) //if num in numbers is even
                {
                    sum += num; //sum = sum + num
                    count++; //increment list numbers by another index. incremented index will have an even value.
                }
            }

            if (count > 0)
            {
                return sum / count; //calculating average of all values added to the variable, 'sum'.
            }
            else
            {
                return 0;
            }

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var n = numbers.Where(num => num % 2 == 0);

            if (n.Count() == 0)
            return 0;

            return n.Average();
        }

        public int Factorial(int number)
        {

        var fact = 1; //start with the number 1.

            if (number < 0) //sort of like a checker. we don't want there to be a vlaue less than zero because negative numbers might crash the program here.
            {
                throw new ArgumentOutOfRangeException(); //I'm guessing this just ends the program.
            }
            for (int i = number; i > 0; i--) //for every number in the collection, multiply it by 1. i is starting at the end of the list with greatest value, which is why we are decrementing by 1 here.
            { //i believe this is a way to create a list or an array without implementing the system.collections.generic; directive.
                fact *= i; //made the mistake of writing in 1 here the first time. 
            }

            return fact; //we have to return something because the method is expecting us to. better make sure the variable being retunred is in the same return type as what the method is expecting.
        //{
        //    if (number == 0) //this is called recursion; whereby a method is calling upon itself. This will very likely lead to a program crash.
        //    { //recalling the concept of the film, inception, rather than calling a for loop.
        //        return 1; //once it reaches zero, it should return 1.
        //    }
        //    return number * Factorial(number - 1); //weird that we're calling a method within its own scope here, I feel like it reads in such a way where 
        }
    }
}
