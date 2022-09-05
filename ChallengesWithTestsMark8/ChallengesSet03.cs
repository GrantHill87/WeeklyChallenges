using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++) //remember, in an array, where i represents increments of 1, 1 is not necessarily a number. Confusing right? In this context,
            {                                     //i represents an index placement, or a unit of a given index, which can be, in this case, expressed by the number 1.
                if (vals[i] == false)             //for as long as i is less than the length of the array, it will increment by an index of 1.
                {
                    return true;                  //wish I could see what this function was doing as it was looping, but I imagine, based on how the method is written, and what
                }                                 //the 'if' statement is expressing, vals represents an array with index units containing the following; 'true', 'false', 'true', 'false',
                                                  //for as long as i is less than the length of vals (the array). So, in that case, we could clearly see that this array contains, 'false', in it.
            }                                     //if the array of 'vals' has a 'false' in it, return 'true'.
            return false;
            //if (vals == null) //this function doesn't work because it's suggesting that if the array is equal to zero, then return false, else, return true. This doesn't have a way
            //{                 //of checking the array, 'vals', for its contents of, 'true', or 'false', it is only checking for zero, and then the rest of the indexes would potentially
            //    return false; //be returned as true, without even being checked for a 'false' value, which, based on the test, would make the correct reponse true, assuming the array
            //}                 //had a 'false' value located somewhere in its index. The other thing too with this code; is bool[] vals already defined as an array in the parameter of the method?
            //return true;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) //we make a checker here for zero, in part because zero isn't considered an odd number, but more importantly, very likely because the code might crash if we don't make this checker first.
            {
                return false;
            }
            return numbers.Sum() % 2 != 0 ? true : false; //using modulus to determine if the sum of all numbers in the given list is an odd or even value, returning a value of true or false.
            //if (numbers == null || numbers.Count() == 0)
            //{
            //  return false;
            //}
            //var sum = numbers.Sum();
            //return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password) //if we don't express the results of our checkers in the format of a return value, especially when
        {                                                                //our method expects a type of return (it isn't void), our code will not run until it has a response to give in the format of a return.
            //var ContainsUpper = password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsDigit(x));]

            var isLower = false; //we set the variables here to false, because we need to prove whether or not they're true.
            var isUpper = false; //this is a test, we're not here to give this method the benefit of the doubt.
            var isNumber = false; //I figure if these variables were set to true first, then this method assumes all characters of the password are satisfactory, and would fail all the tests as a result.

            for (int i = 0; i < password.Length; i++) //we define the size of an array here; initializing and assigning an array at the same time. i determines the size of the array.
            {                                         //a great way to build an array quickly without having to define it; no input needed. We simply make the array, with its size defined by i
                if (char.IsLower(password[i]))        //incremented by units of 1, since fractions of 1, or increments bigger than 1 are obselete, and effectively unnecessary here. This is because
                {                                     //we are checking individual characters of a string, that presumably defines the spectrum of a password. We want to make sure each character meets our criteria.
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if (isLower == true && isUpper == true && isNumber == true) //this is where we take the hard work of our checkers combing through the array, return a value of true or false, based upon their findings.
            {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //var x = password.Any(char.IsUpper); //this code looks like it is only missing checkers for, 'isNumber', and 'isLower'. Also not sure if the password was already defined as an array
            //var y = password.Any(char.IsUpper); //via the parameter of the method here, but as far as I know, in order to check each index of the array itself, we must define the scope of that array first.
            //var z = password.Any(char.IsUpper); //in defining the array, as depicted above, we can then craft checkers to evaluate each index of that newly defined array.
                                                  //this is especially efficient when making the return of the method boolean based. Else, it may be an even lengthier script.
            //if (x == true && y == true && z == true)
            //{
            //    return true;
            //}
            //else return false;

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) //have you ever tried dividing by zero? :D
            {
                return 0;
            }
            var num = dividend / divisor;
            return num;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var x = Enumerable.Range (1, 100);
            return x.Where(x => x % 2 != 0).ToArray(); //the 'where' method is predefined, and checks each index of an array, where we said 'x' was equal to a range of 1 and 100.
        }                                              //since we don't have a predefined method to check for odd or even numbers, we make our own.

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) //we set i equal to 0 because we want to start at the first index. Starting from infinity, working downward, doesn't make any sense. Might also crash the computer.
            {
                words[i] = words[i].ToUpper(); //calling a method that will change all characters, or indexes of the given array, 'words', to uppercase.
            }
        }
    }
}
