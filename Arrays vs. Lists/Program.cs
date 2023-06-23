/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: Array's vs. Lists
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/20/2023
* -------------------------------------------------------------------
*/

namespace Arrays_vs._Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfGrades;
            
            //prompts the user how many grades you want to enter
            Console.WriteLine("----------ARRAYS----------");
            while (true)
            {
                try
                {
                    Console.Write("How many grades would you like to enter: ");
                    numOfGrades = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //creates an array of the user and makes the user fill the array
            double[] arrayOfGrades = new double[numOfGrades];
            for(int i = 0; i < arrayOfGrades.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Enter grade {i + 1}: ");
                        arrayOfGrades[i] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            
            //displays grade array
            Console.WriteLine("--------------------------\nYour grade array looks like the following:");
            for (int i = 0; i < arrayOfGrades.Length; i++)
            {
                Console.WriteLine($"Grade {i + 1}: {arrayOfGrades[i]}");
            }
            Console.WriteLine("--------------------------");

            int newNumOfGrades;
            
            //prompts user to add to grade array
            while (true)
            {
                try
                {
                    Console.Write("Enter how many more grades would you like to add: ");
                    newNumOfGrades = Convert.ToInt32(Console.ReadLine()) + numOfGrades;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //creates new array with the input from the increased grade array and fills with old array data
            double[] newArrayOfGrades = new double[newNumOfGrades];
            for (int i = 0; i < arrayOfGrades.Length; i++)
            {
                newArrayOfGrades[i] = arrayOfGrades[i];
            }

            //prompts user to fill new array spots with data
            for (int i = numOfGrades; i < newArrayOfGrades.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Enter grade {i + 1}: ");
                        newArrayOfGrades[i] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            //displays new array
            Console.WriteLine("--------------------------\nYour new grade array looks like the following:");
            for (int i = 0; i < newArrayOfGrades.Length; i++)
            {
                Console.WriteLine($"Grade {i + 1}: {newArrayOfGrades[i]}");
            }
            Console.WriteLine("--------------------------");

            //prompts user to remove a grade index
            int removeIndexOfGrade;
            while (true)
            {
                try
                {
                    Console.Write($"Enter what grade you would like to remove (0 - {newNumOfGrades}): ");
                    removeIndexOfGrade = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (removeIndexOfGrade + 1> 0 && removeIndexOfGrade < newNumOfGrades) 
                    {
                        break;
                    }
                    Console.WriteLine("Input string was not within the index of the array.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //removed the grade the user selected and moves all data to the left one position leaving the last as a 0
            for (int i = removeIndexOfGrade; i < newArrayOfGrades.Length; i++)
            {
                if (i != newArrayOfGrades.Length - 1)
                {
                    newArrayOfGrades[i] = newArrayOfGrades[i + 1];
                }
                else
                {
                    newArrayOfGrades[i] = 0;
                }
            }

            //displays edited array
            Console.WriteLine("--------------------------\nYour new edited grade array looks like the following:");
            for (int i = 0; i < newArrayOfGrades.Length; i++)
            {
                Console.WriteLine($"Grade {i + 1}: {newArrayOfGrades[i]}");
            }
            Console.WriteLine("--------------------------");

            //prompts user to add a new grade
            double addGrade;
            while (true)
            {
                try
                {
                    Console.Write($"Enter a grade value to add: ");
                    addGrade = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //prompts user to add a grade index
            int addIndexOfGrade;
            while (true)
            {
                try
                {
                    Console.Write($"Enter what postion you would like to add the grade to (0 - {newNumOfGrades}): ");
                    addIndexOfGrade = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (addIndexOfGrade + 1 > 0 && addIndexOfGrade < newNumOfGrades)
                    {
                        break;
                    }
                    Console.WriteLine("Input string was not within the index of the array.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Added the grade the user selected and moves all data to the right one position leaving the last as a 0
            double currentTempVal;
            double nextTempVal;
            currentTempVal = newArrayOfGrades[addIndexOfGrade];
            newArrayOfGrades[addIndexOfGrade] = addGrade;
            for (int i = addIndexOfGrade + 1; i < newArrayOfGrades.Length; i++)
            {
                nextTempVal = newArrayOfGrades[i];
                newArrayOfGrades[i] = currentTempVal;
                currentTempVal = nextTempVal;
            }

            //displays edited array
            Console.WriteLine("--------------------------\nYour new edited grade array looks like the following:");
            for (int i = 0; i < newArrayOfGrades.Length; i++)
            {
                Console.WriteLine($"Grade {i + 1}: {newArrayOfGrades[i]}");
            }
            Console.WriteLine("--------------------------");

            //prompts the user how many grades you want to enter
            int numOfListGrades;
            Console.WriteLine("\n----------LISTS-----------");
            while (true)
            {
                try
                {
                    Console.Write("How many grades would you like to enter: ");
                    numOfListGrades = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //makes the user fill the list up to the entered amount
            List<double> listOfGrades = new List<double>();
            for (int i = 0; i < numOfListGrades; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Enter grade {i + 1}: ");
                        listOfGrades.Add(Convert.ToDouble(Console.ReadLine()));
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            //displays list
            Console.WriteLine("--------------------------\nYour grade list looks like the following:");
            int gradePos = 1;
            foreach(double item in listOfGrades)
            {
                Console.WriteLine($"Grade {gradePos++}: {item}");
            }

            //prompts the user how many more grades you want to enter
            int oldNumOfListGrades = numOfListGrades;
            while (true)
            {
                try
                {
                    Console.Write("--------------------------\nHow many more grades would you like to enter: ");
                    numOfListGrades = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //makes the user fill the list up to the new entered amount
            for (int i = 0; i < numOfListGrades; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Enter grade {i + 1 + oldNumOfListGrades}: ");
                        listOfGrades.Add(Convert.ToDouble(Console.ReadLine()));
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            //displays list
            Console.WriteLine("--------------------------\nYour grade new list looks like the following:");
            gradePos = 1;
            foreach (double item in listOfGrades)
            {
                Console.WriteLine($"Grade {gradePos++}: {item}");
            }

            //asks user for a position to remove from the list
            while (true)
            {
                try
                {
                    Console.Write($"Enter what grade you would like to remove (0 - {oldNumOfListGrades + numOfListGrades}): ");
                    removeIndexOfGrade = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (removeIndexOfGrade + 1 > 0 && removeIndexOfGrade < oldNumOfListGrades + numOfListGrades)
                    {
                        break;
                    }
                    Console.WriteLine("Input string was not within the index of the array.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //removes index from the list
            listOfGrades.RemoveAt(removeIndexOfGrade);

            //displays new list
            Console.WriteLine("--------------------------\nYour new grade list looks like the following:");
            gradePos = 1;
            foreach (double item in listOfGrades)
            {
                Console.WriteLine($"Grade {gradePos++}: {item}");
            }

            //prompts user to add a new grade
            while (true)
            {
                try
                {
                    Console.Write($"Enter a grade value to add: ");
                    addGrade = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //prompts user to add a grade index
            while (true)
            {
                try
                {
                    Console.Write($"Enter what postion you would like to add the grade to (0 - {oldNumOfListGrades + numOfListGrades - 1}): ");
                    addIndexOfGrade = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (addIndexOfGrade + 1 > 0 && addIndexOfGrade < oldNumOfListGrades + numOfListGrades - 1)
                    {
                        break;
                    }
                    Console.WriteLine("Input string was not within the index of the array.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //adds grade at index input
            listOfGrades.Insert(addIndexOfGrade, addGrade);

            //displays new list
            Console.WriteLine("--------------------------\nYour new grade list looks like the following:");
            gradePos = 1;
            foreach (double item in listOfGrades)
            {
                Console.WriteLine($"Grade {gradePos++}: {item}");
            }

        }
    }
}