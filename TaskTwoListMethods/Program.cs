
List<double> list = [];
bool isRunning = true;


while (isRunning)
{
    Console.ForegroundColor = ConsoleColor.Green; // i got from youtube c# course to change the color of the console 
    Console.WriteLine("main menu");
    Console.WriteLine("==============================");

    Console.WriteLine("p - print numbers");
    Console.WriteLine("A - Add number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("F - finad a number");
    Console.WriteLine("C - Clear the whole list ");
    Console.WriteLine("SORT - sort the list in asc and desc order");
    Console.WriteLine("Q - Quit");
    Console.WriteLine("==============================");
    Console.ForegroundColor = ConsoleColor.White;

    String command = Console.ReadLine().ToUpper().Trim(); // usin to upper & trim for handle small case letters and spacing 

    switch (command)
    {
        case "P":

            if (list.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==============================");
                Console.WriteLine("the list is empty");
                Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("list = [");
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != list.Count - 1)
                    {
                        Console.Write($"{list[i]},");

                    }
                    else
                    {
                        Console.WriteLine($"{list[i]}]");

                    }
                }
            }

            break;

        case "A":
            try
            {
                Console.Write("enter the number you want to add ==> ");
                double newNumber = Convert.ToDouble(Console.ReadLine());
                list.Add(newNumber);
                Console.WriteLine($"the number {newNumber} is added ");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("==============================");
                Console.WriteLine("Invalid input!, Enter number only");
                Console.WriteLine("==============================");

                Console.ForegroundColor = ConsoleColor.White;
            }
            break;

        case "M":
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {

                sum += list[i];
            }
            double result = sum / list.Count;

            Console.WriteLine($"the mean of the list == {result}");
            break;

        case "S":
            if (list.Count > 0)
            {
                double minNumber = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (minNumber > list[i])
                    {
                        minNumber = list[i];
                    }
                }
                Console.WriteLine($"the smallest number in the list is ==> {minNumber}");
            }
            break;

        case "L":

            if (list.Count > 0)
            {
                double maxNum = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (maxNum > list[i])
                    {
                        maxNum = list[i];
                    }
                }
                Console.WriteLine($"the largest number in the list is ==> {maxNum}");

            }
            break;

        case "F":
            try
            {

                Console.Write("enter the number to search for ==> ");
                double numToFind = Convert.ToInt32(Console.ReadLine());
                bool found = false;

                for (int i = 0; i < list.Count; i++)
                {
                    if (numToFind == list[i])
                    {
                        Console.WriteLine($"the number is in the list on the idex : i = {i}");
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"the number {numToFind} isn't found in the list");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("==============================");
                Console.WriteLine("Invalid input!, Enter number only");
                Console.WriteLine("==============================");

                Console.ForegroundColor = ConsoleColor.White;

            }
            break;

        case "Q":
            Console.WriteLine("you exit the app");
            isRunning = false;
            break;

        case "C":
            list.Clear();
            Console.WriteLine("the list is cleared");
            break;


        case "SORT":

            Console.Write("Do you want it in Desc order Enter (Y/N) : ");
            String isDesc = Console.ReadLine().Trim().ToUpper();
            if (isDesc == "N")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int index = i;
                    for (int j = index + 1; j < list.Count; j++)
                    {
                        if (list[index] > list[j])
                        {
                            double temp = list[index];
                            list[index] = list[j];
                            list[j] = temp;

                        }
                    }

                }
            }
            else if (isDesc == "Y")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    int index = i;
                    for (int j = index + 1; j < list.Count; j++)
                    {
                        if (list[index] < list[j])
                        {
                            double temp = list[index];
                            list[index] = list[j];
                            list[j] = temp;

                        }
                    }

                }
            }
            else { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid input, must type (Y/N) !!");
                Console.ForegroundColor = ConsoleColor.White;
                break; }


            if (list.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==============================");
                Console.WriteLine("the list is empty");
                Console.WriteLine("==============================");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("list = [");
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != list.Count - 1)
                    {
                        Console.Write($"{list[i]},");

                    }
                    else
                    {
                        Console.WriteLine($"{list[i]}]");

                    }
                }
            }

            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================");
            Console.WriteLine("wrong instruction command");
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

}
