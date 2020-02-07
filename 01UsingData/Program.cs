using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01UsingData
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise1
            #region Addition of two numbers
            // Console.WriteLine("Enter First Number");
            // int firstNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter second number");
            // int secondnumber = int.Parse(Console.ReadLine());

            // int reult = firstNumber + secondnumber;

            // Console.WriteLine("{0} + {1} = {2}", firstNumber, secondnumber, reult);
            #endregion

            //exercise2
            #region define length and width,calculate cost of carpating the room 

            //const double codtPerFeet = 2;

            //Console.WriteLine("Enter the length of room");
            //double length = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the width of room");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;

            //double totalCost = area * codtPerFeet;

            //Console.WriteLine("The price for carpeting of length {0} and width {1} is {2}",length,width,totalCost);

            #endregion

            //exercise3
            #region Enter time in minutes ,convert that into hr and remaining minutes.

            //Console.WriteLine("Enter total amounts of minutes only");
            //int totaltime = int.Parse(Console.ReadLine());
            //int hours = totaltime / 60;
            //int remainingminutes = totaltime % 60;

            //Console.WriteLine("{0} minutes equals to {1} hour and {2} minutes",totaltime,hours,remainingminutes);

            #endregion

            //exercise4
            #region using  conditional if statement
            //Console.WriteLine("Enter the value");
            //double value = double.Parse(Console.ReadLine());

            //if (value > 7.50 || value > 49)
            //{
            //    Console.WriteLine("Entered rate value is acceptable.");
            //}
            //else
            //{
            //    Console.WriteLine("entered rate value is not acceptable");
            //}
            #endregion

            //exercise5
            #region calculating area,depending on area value decide fee and show total cost for 20 week depending on fee value

            //Console.WriteLine("enter length of your ward");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter width of your ward");
            //double width = double.Parse(Console.ReadLine());

            //double squareFeet = length * width;
            //double weeklyFee;
            //if (squareFeet< 400)
            //{
            //   weeklyFee = 25;

            //}
            //else if(squareFeet >=400 && squareFeet < 600)
            //{
            // weeklyFee = 35;
            //}
            //else
            //{
            //     weeklyFee = 50;
            //}

            //Console.WriteLine("calculated weekkly fee is {0}",weeklyFee);

            //Console.WriteLine("Calculated 20 weeks fee is {0}",weeklyFee * 20);

            #endregion

            //exercise6

            #region generating random number,then allowing user to guess number and then giving result about guess

            //Random randomGenerator = new Random();
            //int randomNumber = randomGenerator.Next(1, 101); //short code to generate random number within given range

            //Console.WriteLine("enter your guess between 1 to 10");
            //int myGuess = int.Parse(Console.ReadLine());

            //if (myGuess > randomNumber)
            //{
            //    Console.WriteLine("your gauess is high");
            //}
            //else if (myGuess == randomNumber)
            //{
            //    Console.WriteLine("your guess is exacly corrcet");

            //}
            //else
            //{
            //    Console.WriteLine("your gauess is low");

            //}

            //Console.WriteLine("random number was {0}",randomNumber);
            #endregion

            //exercise7
            #region using do-while to repeate untill expected amount is entered.
            //double payrate;
            //do
            //{
            //    Console.WriteLine("enter valid payrate amount");
            //    payrate = double.Parse(Console.ReadLine());
            //} while (payrate < 5 || payrate > 50); //it will repeat untill the bvalue is in between 5 to 50.

            //Console.WriteLine("Final valid pay rate you entered is {0}",payrate);
            #endregion

            //exercise8
            #region program that adds the interger between 1 to 50

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("sum is {0}",sum);
            #endregion

            //exercise9
            #region using do while guess random number and count how much try it taken to guess exactly

            //Random randomGenerator = new Random();
            //int randomNumber = randomGenerator.Next(1, 11);

            //int userGuess;
            //int amountOfGuesses = 0;

            //do
            //{
            //    Console.WriteLine("enter your guess");

            //    userGuess = int.Parse(Console.ReadLine());
            //    if (userGuess > randomNumber)
            //    {
            //        Console.WriteLine("your guess is too high");
            //    }
            //    else if (userGuess < randomNumber)
            //    {
            //        Console.WriteLine("your guess is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("your guess is right.");
            //    }
            //    amountOfGuesses++;

            //} while (userGuess != randomNumber);

            //Console.WriteLine("you guessed {0} times",amountOfGuesses);
            #endregion

            //exercise10
            #region sorting an array(binary sort),sorting and reversing an array with function


            #region binary search
            //int[] myArray = { 10, 15, 20, 25, 30, 35, 40, 45 };
            //Console.WriteLine("Enter number you want to check if its exists");
            //int number = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray, number);

            //if (answer < 0)
            //{
            //    Console.WriteLine("the number doesnot exits");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers position is {0}", answer);
            //}
            #endregion


            #region sorting an array
            //int[] mysortArray = { 10, 7, 5, 2, 55, 64 };
            //Array.Sort(mysortArray);
            //for (int i = 0; i < mysortArray.Length; i++)
            //{
            //    Console.WriteLine(mysortArray[i]);
            //}
            #endregion//


            #region reversing an array 
            //int[] myreserseArray = { 10, 5, 2, 7, 55, 11 };
            //Array.Reverse(myreserseArray);
            //for (int i = 0; i < myreserseArray.Length; i++)
            //{
            //    Console.WriteLine(myreserseArray[i]);
            //}
            #endregion


            #endregion

            //exercise11
            #region check if u can deliver parcel at given zip code or not
            //string[] zipCodes = { "151423","568791","919172","561133","135131","817161","019181","181716","181818","234151" };
            //Console.WriteLine("Enter zip code you want to check if its exists");
            //string code = (Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < zipCodes.Length; i++)
            //{
            //    if (code == zipCodes[i])
            //    {
            //        found = true;
            //        break;

            //    }
            //}

            //if (found == true)
            //{
            //    Console.WriteLine("we can deliver parcel at given zip code");
            //}
            //else
            //{
            //    Console.WriteLine("unable to deliver at given zip code");
            //}

            #endregion

            //exercise12
            #region allow teacher to enter name and marks of student,then find avg and max marks among student.

            //Console.WriteLine("enter number of student in the class");
            //int noOfStu = int.Parse(Console.ReadLine());

            //string[] aStudents = new string[noOfStu];
            //double[] amarks = new double[noOfStu];

            //double maxMarks = 0;
            //double avgMarks = 0;
            //string highestmarksName = "";

            //for (int i = 0; i < noOfStu; i++)
            //{
            //    Console.WriteLine("enter student #{0} name",i+1);

            //    string name = Console.ReadLine();
            //    aStudents[i] = name;

            //    Console.WriteLine("enter student #{0} marks", i + 1);

            //    double mark = double.Parse(Console.ReadLine());
            //    amarks[i] = mark;

            //    avgMarks = avgMarks + mark;

            //    if (mark > maxMarks)
            //    {
            //        maxMarks = mark;

            //        highestmarksName = name;
            //    }
            //}

            //avgMarks = avgMarks / noOfStu;

            //Console.WriteLine("average marks of the class is {0}",avgMarks);
            //Console.WriteLine("highest marks of the class is {0}",maxMarks);
            //Console.WriteLine("highest marks obtained by {0}",highestmarksName);


            #endregion


            //exercise13
            #region guess the word game

            ////get random word and hide it
            //            string[] words = {"jump","kaustubh","cricket","football","god","google","job","universe"};
            //            Random random = new Random();
            //            int randomIndex = random.Next(0,8); //random fuc returns integer only
            //            string selectedWord = words[randomIndex];
            //            string hiddenWord = "";
            //            for (int i = 0; i < selectedWord.Length; i++)
            //            {
            //                hiddenWord += "*";
            //            }
            ////Console.WriteLine(hiddenWord);


            ////gussing stuff
            //                while (hiddenWord.Contains("*"))
            //                {
            //                    Console.WriteLine("Word: {0}",hiddenWord);
            //                    Console.Write("Guess the letter >>");
            //                    char letter = char.Parse(Console.ReadLine());
            //                    bool containsLetter = false;

            //                    for (int i = 0; i < selectedWord.Length; i++)
            //                    {
            //                        if (selectedWord[i] == letter)
            //                        {
            //                            hiddenWord = hiddenWord.Remove(i, 1);
            //                            hiddenWord = hiddenWord.Insert(i, letter.ToString());
            //                            containsLetter = true;
            //                        }
            //                    }
            //                    if (containsLetter == true)
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Green;
            //                        Console.WriteLine("YES,{0} is in the word",letter);
            //                    }
            //                    else
            //                    {
            //                        Console.ForegroundColor = ConsoleColor.Red;
            //                        Console.WriteLine("SORRY,{0} is not in the word",letter);
            //                    }
            //                    Console.ResetColor();

            //                }

            ////you won
            //                Console.WriteLine("congratulations you guessed correctly.....word is {0}",selectedWord);
            #endregion

            //exercise14
            #region square and cube of a number


            //Console.WriteLine("Enter the number");
            //int number = int.Parse(Console.ReadLine());

            //int squared = Square(number);

            //int cubed = Cube(number);

            //Console.WriteLine("Square and cube of {0} is {1} and {2} respectively.",number,squared,cubed);

            //Go_FOR_e14_start_end





            #endregion

            //exercise15
            #region getting sum of multiple numbers and also sum of elements of array
            //SUM(5);
            //SUM(10, 12, 13);
            //SUM(18, 191, 181, 374, 64);

            //int[] myArray = { 1,2,3,4,5,6,7,8,9,10};

            //SUM(myArray);
            #endregion

        }


        #region function of e14
        //e14START
        //public static int Square(int number)
        //{
        //    int answer = number * number;
        //    return answer;
        //}

        //public static int Cube(int number)
        //{
        //    int answer = Square(number) * number;
        //    return answer;
        //}
        //e14END
        #endregion

        #region function of e15
        //e15START
        //public static void SUM(params int[] myArray)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        sum += myArray[i];
        //    }
        //    Console.WriteLine("The final sum is {0}", sum);
        //}
        //e15END
        #endregion



    }
}