using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] printMinuetNumber = new int[16];                                                                      // initialize an array of 16 
            string[] filesMinuet = new string[16];                                                                      // initialize a string of 16 
            int[,] MinuetNumber = new int[,]                                                                            // initialize an array of the numbers from minuet 

            {
                {96, 22, 141, 41, 105, 122, 11, 30, 70, 121, 26, 9, 122, 49, 109, 14},
                {32, 6, 128, 63, 146, 46, 134, 81, 117, 39, 126, 56, 174, 18, 116, 83},
                {69, 95, 158, 13, 153, 55, 110, 24, 66, 139, 15, 132, 73, 58, 145, 79},
                {40, 17, 113, 85, 161, 2, 159, 100, 90, 176, 7, 34, 67, 160, 52, 170},
                {148, 74, 163, 45, 80, 97, 36, 107, 25, 143, 64, 125, 76, 137, 1, 93},
                {104, 157, 27, 167, 154, 68, 118, 91, 138, 71, 150, 29, 101, 162, 23, 151},
                {152, 60, 171, 53, 99, 133, 21, 127, 16, 155, 57, 175, 43, 168, 89, 172},
                {119, 84, 114, 50, 140, 86, 169, 94, 120, 88, 48, 166, 51, 115, 72, 111},
                {98, 142, 42, 156, 75, 129, 62, 123, 65, 77, 19, 82, 137, 38, 149, 8},
                {3, 87, 165, 61, 135, 47, 147, 33, 102, 4, 31, 164, 144, 59, 173, 78},
                {54, 130, 10, 103, 28, 37, 106, 5, 35, 20, 108, 92, 12, 124, 44, 131},
            };

            Random ran = new Random();                                                                                  // using random


            for (int i = 0; i < MinuetNumber.GetLength(0); i++)                                                 // for loop to loop through dimension 1
            {
                for (int j = 0; j < MinuetNumber.GetLength(1); j++)                                             // for loop to loop through dimension 2
                {
                    int Dice = ran.Next(0, 10);                                                                        // initialize a Dice that rolls between 0 and 10
                    printMinuetNumber[j] = MinuetNumber[Dice, j];                                                      // stores the chosen number from first row to printMinuetNumber
                }
            }

            Console.WriteLine("This is which Minuet files that are played ");                                       
            for (int i = 0; i < 16; i++)                                                                               // for loop to print out which numbers that are beeing played
            {
                Console.Write(printMinuetNumber[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < filesMinuet.Length; i++)                                                               // loops through the sound files that has the numbers from printMinuetNumber
            {
                filesMinuet[i] = $@"C:\Users\mathi\source\repos\Mozart\filesMinuet\M{printMinuetNumber[i]}.wav";
            }

            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();                                    // initialize our sound player

            foreach (string soundtrack in filesMinuet)                                                                // playes the sound files that are stored in filesMinuet
            {
                soundPlayer.SoundLocation = soundtrack;
                soundPlayer.Load();
                soundPlayer.PlaySync();
            }

            int[,] trioNumber = new int[,]
            {
                {72, 6, 59, 25, 81, 41, 89, 13, 36, 5, 46, 79, 30, 95, 19, 66},
                {56, 82, 42, 74, 14, 7, 26, 71, 76, 20, 64, 84, 8, 35, 47, 88},
                {75, 39, 54, 1, 65, 43, 15, 80, 9, 34, 93, 48, 69, 58, 90, 21},
                {40, 73, 16, 68, 29, 55, 2, 61, 22, 57, 49, 77, 57, 87, 33, 10},
                {83, 3, 28, 53, 37, 17, 44, 70, 63, 85, 32, 96, 12, 23, 50, 91},
                {18, 45, 62, 38, 4, 27, 52, 94, 11, 92, 24, 86, 51, 60, 78, 31},
            };


            string[] FilesTrio = new string[16];
            int[] printTrio = new int[16];


            for (int i = 0; i < trioNumber.GetLength(0); i++)
            {
                for (int j = 0; j < trioNumber.GetLength(1); j++)
                {
                    int dice2 = ran.Next(0, 6);
                    printTrio[j] = trioNumber[dice2, j];
                }
            }

            Console.Clear();
            Console.WriteLine("This is which Trio files that are played ");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(printTrio[i] + " ");
            }

            for (int i = 0; i < FilesTrio.Length; i++)
            {
                FilesTrio[i] = $@"C:\Users\mathi\source\repos\Mozart\filesTrio\T{printTrio[i]}.wav";
            }

            System.Media.SoundPlayer soundPlayer1 = new System.Media.SoundPlayer();

            foreach (string soundtrack in FilesTrio)
            {
                soundPlayer1.SoundLocation = soundtrack;
                soundPlayer1.Load();
                soundPlayer1.PlaySync();
            }
        }
    }
}