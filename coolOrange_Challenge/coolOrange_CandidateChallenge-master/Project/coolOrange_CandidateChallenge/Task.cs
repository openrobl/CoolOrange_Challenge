using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    class Task: IPriority, IComplexity, IComparable
    {
        string Name;
        int Complexity, Priority;

        public Task(string Name, int  Complexity, int  Priority) // Konstruktor
        {

            this.Priority = Priority;
            this.Complexity = Complexity;
            this.Name = Name;
        }


  
        public int SetPriority
        {
            set
            {
                Priority = value;
            }

        }
        public int GetPriority
        {
            get
            {
                return Priority;
            }

        }

        public enum prio
        {
            MIN_PRIORITY, MED_PRIORITY, MAX_PRIORITY
        }

        //Complexity
        public int SetComplexity
        {
            set
            {
                Complexity = value;
            }

        }
        public int GetComplexity
        {
            get
            {
                return Complexity;
            }

        }

        //Comparable
        int compareState;
        public string  CompareTo(Task obj)
        {
            if (Complexity < obj.GetComplexity)
            {
                return "0";
            }
            else if (Complexity == obj.GetComplexity)
            {
                return "1";
            }
            else
            {
                return "2";
            }
           
            
        }


       
    }
    class TaskDriver
    {
        

        public TaskDriver()
        {

        }
        static void Main(string[] args)
        {
            bool on = true;
            while (on)
            {



                try
                {
                    Console.WriteLine("CoolOrange_CandidateChallange");
                    Console.WriteLine("[1] Palindrome Checker");
                    Console.WriteLine("[2] Array utility");
                    Console.WriteLine("[3] Taks");
                    Console.WriteLine("[4] Quit");
                    Byte input_ = Convert.ToByte(Console.ReadLine());

                    switch (input_)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Palindrome Checker");
                            Console.WriteLine("Please enter a word");
                            PalindromeChecker checker = new PalindromeChecker();
                            string input_text = Console.ReadLine();
                            bool ispal = checker.IsPalindrome(input_text);

                            if (ispal == true)

                                Console.WriteLine("is a palindrom");

                            else
                                Console.WriteLine("is not a palindrom");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Array Utility\n");

                            int[] input_Array = { 2, 4, 6, 23, 869, 23, 765, 432, 21, 434,5 }; //testwerte
                            int[] sorted_array = { 2, 4, 6, 23, 28, 432, 765, 800,845 }; 
                            int i = 2;
                            int j = 7;
                            int q = 28;
                            int rows = 5;
                            int cols = 6;
                            int min = 7;
                            int max = 80;
                            int size = 70;

                            Console.WriteLine("Find Max " + ArrayUtility.FindMax(input_Array, i, j));
                            Console.WriteLine("Min Pos " + ArrayUtility.FindMinPos(input_Array, i, j));
                            Console.WriteLine("Swap ");
                            int[] swap = ArrayUtility.Swap(input_Array, i, j); //ausgabe des Arrays
                            foreach (var item in swap)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine("\nCreateRandomArray ");
                            Console.WriteLine("Min " + min);
                            Console.WriteLine("Max "+ max);
                            Console.WriteLine("Size " + size);
                             int[] random_Array =  ArrayUtility.CreateRandomArray(size, min, max);
                            foreach (var item in random_Array)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine("\nCreateRandomMatrix " );
                            int[,] matrix = ArrayUtility.CreateRandomMatrix(rows, cols, min, max);
                            for (int a = 0; a < rows; a++)
                            {
                                for (int b = 0; b < cols; b++)

                                    Console.WriteLine(matrix[a, b]);
                            }
                            Console.WriteLine("\nFindInSortedArrary; Position: " + ArrayUtility.FindInSortedArrary(sorted_array, q)+"\n");



                            break;
                        case 3:
                            Task DoingHomework = new Task("Doing Homework", 10, 8);
                            Task EatingLunch = new Task("Eating Lunch", 1, 2);
                            Task Programming = new Task("Programming", 5, 5);



                            Console.WriteLine("Doing Homework priority: " + DoingHomework.GetPriority + " complexity: " + DoingHomework.GetComplexity); // ausgabe der Aufgaben
                            Console.WriteLine("Eating Lunch  priority: " + EatingLunch.GetPriority + " complexity: " + EatingLunch.GetComplexity);
                            Console.WriteLine("Programming priority: " + Programming.GetPriority + " complexity: " + Programming.GetComplexity);

                            string value = "";
                            string temp =  DoingHomework.CompareTo(EatingLunch); // vergleichen der Aufgaben
                            string temp2 =  EatingLunch.CompareTo(Programming);
                            string temp3 =  Programming.CompareTo(DoingHomework);
                      

                            switch (temp)
                            {

                                case "0":
                                    if (temp2 == "0")
                                        value = "Earing lunch";
                                    break;
                                case "1":
                                    if (temp2 == "0")
                                        value = "Programming";
                                    break;
                                case "2":
                                    if (temp3 == "0")
                                        value = "DoingHomework";
                                    break;
                            }

                            Console.WriteLine(value + " is one of the most important things");

                            break;

                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch
                {

                }
            }


        }

    }

    
}
