
using Func;
namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.Write("Give me a command (!help): ");
                string userinput = Console.ReadLine();
                if (userinput == "!help")
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("Commands:");
                    Console.WriteLine("!multi");
                    Console.WriteLine("!div");
                    Console.WriteLine("!mod");
                    Console.WriteLine("!add");
                    Console.WriteLine("!sub");
                    Console.WriteLine("!resume");
                    Console.WriteLine("!percent");
                    Console.WriteLine("!avg");
                    Console.WriteLine("!power");
                    Console.WriteLine("!scinote");
                    Console.WriteLine("Type 'exit' to stop the program");
                }
                else if (userinput == "!multi")
                {
                    Console.Write("How many numbers? (2-10): ");
                    int numberofnumbers = Convert.ToInt32(Console.ReadLine());
                    if (numberofnumbers == 2)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray2 = { nums, numbs };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray2)}");
                    }
                    else if (numberofnumbers == 3)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray3 = { nums, numbs, n };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray3)}");
                    }
                    else if (numberofnumbers == 4)
                    {
                        Console.WriteLine("Give your numbers (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray4 = { nums, numbs, n, nu };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray4)}");
                    }
                    else if (numberofnumbers == 5)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray5 = { nums, numbs, n, nu, num };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray5)}");
                    }
                    else if (numberofnumbers == 6)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray6 = { nums, numbs, n, nu, num, numb };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray6)}");
                    }
                    else if (numberofnumbers == 7)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray7 = { nums, numbs, n, nu, num, numb, numbe };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray7)}");
                    }
                    else if (numberofnumbers == 8)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray8 = { nums, numbs, n, nu, num, numb, numbe, number };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray8)}");
                    }
                    else if (numberofnumbers == 9)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray9 = { nums, numbs, n, nu, num, numb, numbe, number, numbers };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray9)}");
                    }
                    else if (numberofnumbers == 10)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tenth number: ");
                        double ns = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray10 = { nums, numbs, n, nu, num, numb, numbe, number, numbers, ns };

                        Console.WriteLine($"The answer is {func.Multiply(numsarray10)}");
                    }
                    else
                    {
                        Console.WriteLine("Thats not 2-10!!!");
                    }
                }
                else if (userinput == "!div")
                {
                    Console.WriteLine("Give your numbers. (can do decimals)");
                    Console.Write("Number being divided by: ");
                    double nums = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Number thats dividing: ");
                    double numbs = Convert.ToDouble(Console.ReadLine());
                    double[] numsarray2 = { nums, numbs };

                    Console.WriteLine($"The answer is {func.Divide(numsarray2)}");
                }
                else if (userinput == "!mod")
                {
                    Console.WriteLine("Give your numbers. (No decimals)");
                    Console.Write("Number being Moded: ");
                    int nums = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number thats Moding: ");
                    int numbs = Convert.ToInt32(Console.ReadLine());
                    int[] numsarray = { nums, numbs };

                    Console.WriteLine($"The remainder is {func.Modulus(numsarray)}");
                }
                else if (userinput == "!add")
                {
                    Console.WriteLine("How many numbers? (2-10)");
                    int numberofnumbers = Convert.ToInt32(Console.ReadLine());
                    if (numberofnumbers == 2)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray2 = { nums, numbs };

                        Console.WriteLine($"The answer is {func.Add(numsarray2)}");
                    }
                    else if (numberofnumbers == 3)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray3 = { nums, numbs, n };

                        Console.WriteLine($"The answer is {func.Add(numsarray3)}");
                    }
                    else if (numberofnumbers == 4)
                    {
                        Console.WriteLine("Give your numbers (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray4 = { nums, numbs, n, nu };

                        Console.WriteLine($"The answer is {func.Add(numsarray4)}");
                    }
                    else if (numberofnumbers == 5)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray5 = { nums, numbs, n, nu, num };

                        Console.WriteLine($"The answer is {func.Add(numsarray5)}");
                    }
                    else if (numberofnumbers == 6)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray6 = { nums, numbs, n, nu, num, numb };

                        Console.WriteLine($"The answer is {func.Add(numsarray6)}");
                    }
                    else if (numberofnumbers == 7)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray7 = { nums, numbs, n, nu, num, numb, numbe };

                        Console.WriteLine($"The answer is {func.Add(numsarray7)}");
                    }
                    else if (numberofnumbers == 8)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray8 = { nums, numbs, n, nu, num, numb, numbe, number };

                        Console.WriteLine($"The answer is {func.Add(numsarray8)}");
                    }
                    else if (numberofnumbers == 9)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray9 = { nums, numbs, n, nu, num, numb, numbe, number, numbers };

                        Console.WriteLine($"The answer is {func.Add(numsarray9)}");
                    }
                    else if (numberofnumbers == 10)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tenth number: ");
                        double ns = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray10 = { nums, numbs, n, nu, num, numb, numbe, number, numbers, ns };

                        Console.WriteLine($"The answer is {func.Add(numsarray10)}");
                    }
                    else
                    {
                        Console.WriteLine("Not 2-10!!!");
                    }
                }
                else if (userinput == "!sub")
                {
                    Console.WriteLine("Give your numbers. (can do decimals)");
                    Console.Write("First number: ");
                    double nums = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Second number: ");
                    double numbs = Convert.ToDouble(Console.ReadLine());
                    double[] numsarray2 = { nums, numbs };

                    Console.WriteLine($"The answer is {func.Sub(numsarray2)}");
                }
                else if (userinput == "!percent")
                {
                    Console.WriteLine("Give your part and whole.");
                    Console.Write("Part: ");
                    double part = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Whole: ");
                    double whole = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"The answer is {func.Percent(part, whole)}%");
                }
                else if (userinput == "!avg")
                {
                    Console.WriteLine("How many numbers? (2-10)");
                    int numberofnumbers = Convert.ToInt32(Console.ReadLine());
                    if (numberofnumbers == 2)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray2 = { nums, numbs };

                        Console.WriteLine($"The answer is {func.Average(numsarray2)}");
                    }
                    else if (numberofnumbers == 3)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray3 = { nums, numbs, n };

                        Console.WriteLine($"The answer is {func.Average(numsarray3)}");
                    }
                    else if (numberofnumbers == 4)
                    {
                        Console.WriteLine("Give your numbers (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray4 = { nums, numbs, n, nu };

                        Console.WriteLine($"The answer is {func.Average(numsarray4)}");
                    }
                    else if (numberofnumbers == 5)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray5 = { nums, numbs, n, nu, num };

                        Console.WriteLine($"The answer is {func.Average(numsarray5)}");
                    }
                    else if (numberofnumbers == 6)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray6 = { nums, numbs, n, nu, num, numb };

                        Console.WriteLine($"The answer is {func.Average(numsarray6)}");
                    }
                    else if (numberofnumbers == 7)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray7 = { nums, numbs, n, nu, num, numb, numbe };

                        Console.WriteLine($"The answer is {func.Average(numsarray7)}");
                    }
                    else if (numberofnumbers == 8)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray8 = { nums, numbs, n, nu, num, numb, numbe, number };

                        Console.WriteLine($"The answer is {func.Average(numsarray8)}");
                    }
                    else if (numberofnumbers == 9)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray9 = { nums, numbs, n, nu, num, numb, numbe, number, numbers };

                        Console.WriteLine($"The answer is {func.Average(numsarray9)}");
                    }
                    else if (numberofnumbers == 10)
                    {
                        Console.WriteLine("Give your numbers. (can do decimals)");
                        Console.Write("First number: ");
                        double nums = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second number: ");
                        double numbs = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Third number: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fourth number: ");
                        double nu = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Fifth number: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sixth number: ");
                        double numb = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Seventh number: ");
                        double numbe = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Eighth number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ninth number: ");
                        double numbers = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tenth number: ");
                        double ns = Convert.ToDouble(Console.ReadLine());
                        double[] numsarray10 = { nums, numbs, n, nu, num, numb, numbe, number, numbers, ns };

                        Console.WriteLine($"The answer is {func.Average(numsarray10)}");
                    }
                    else
                    {
                        Console.WriteLine("Not 2-10!!!");
                    }
                }
                else if (userinput == "!resume")
                {
                    Console.WriteLine("This is a program that will build a resume using the information you give me.");
                    Console.WriteLine("This is a very basic program that will only provide you a very basic outline");
                    Console.WriteLine("so you might need to chand some things.");
                    Console.WriteLine("Lets begin.");
                    Console.Write("What is your name? ");
                    string username = Console.ReadLine();
                    Console.Write("what job do you want? ");
                    string userjob = Console.ReadLine();
                    Console.Write("What job do you have at the moment? ");
                    string usercurrentjob = Console.ReadLine();
                    if (usercurrentjob == "none" || usercurrentjob == "no" || usercurrentjob == "I dont have one")
                    {
                        usercurrentjob = "I dont have a job at the moment.";
                    }
                    else
                    {
                        usercurrentjob = $"I currently work as a {usercurrentjob}.";
                    }
                    Console.Write("How old are you? ");
                    int userage = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What sort of experience do you have? ");
                    string userexperience = Console.ReadLine();
                    Console.Write("What sort of edjucation do you have? ");
                    string useredjucation = Console.ReadLine();
                    Console.Write("What sort of skills do you have? minimum of one. (if you cant think of one just type 'none') ");
                    Console.Write("First skill: ");
                    string userSkill1 = Console.ReadLine();
                    Console.Write("Second skill: ");
                    string userSkill2 = Console.ReadLine();
                    Console.Write("Phone number? (No spaces or special characters.) ");
                    int userPhone = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Email? ");
                    string userEmail = Console.ReadLine();

                    func.resume(username, userjob, usercurrentjob, userage, userexperience, useredjucation, userSkill1, userSkill2, userPhone, userEmail);
                    Console.WriteLine("  ");
                    Console.WriteLine("Remember, add your own stuff to it. it is most definitly not perfect.");
                }
                else if (userinput == "!power")
                {
                    Console.WriteLine("Give your numbers. (base can be decimal)");
                    Console.Write("Base number: ");
                    double basenum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Exponent: ");
                    int expo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your answer is {func.Power(basenum, expo)}");
                }
                else if (userinput == "!scinote")
                {
                    Console.WriteLine("Give the numbers in the scientific notation.");
                    Console.Write("Give base number (can do decimals): ");
                    double basenum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Give power (No decimals, cant do less than -4): ");
                    int powernum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The answer is {func.SciNote(basenum, powernum)}");
                }
                else if (userinput == "!convert")
                {
                    Console.WriteLine("What type of units are we converting: ");
                    Console.WriteLine("Area");
                    Console.WriteLine("Energy");
                    Console.WriteLine("Frequency");
                    Console.WriteLine("Length");
                    Console.WriteLine("Mass");
                    Console.WriteLine("Pressure");
                    Console.WriteLine("Speed");
                    Console.WriteLine("Temp");
                    Console.WriteLine("Time");
                    Console.WriteLine("Volume");
                    string convertType = Console.ReadLine();
                    if (convertType == "Area")
                    {
                        Console.Write("what are you converting from:");
                        string from = Console.ReadLine();

                        if (from == "SqKm")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();

                            if (to == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoSqM(fromnum));
                            }
                            else if (to == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoSqMi(fromnum));
                            }
                            else if (to == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoSqYd(fromnum));
                            }
                            else if (to == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoSqFt(fromnum));
                            }
                            else if (to == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoSqIn(fromnum));
                            }
                            else if (to == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xonehundo(fromnum));
                            }
                            else if (to == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqKmtoAcre(fromnum));
                            }
                        }
                        else if (from == "SqM")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (to == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoSqKm(fromnum));
                            }
                            else if (to == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoSqMi(fromnum));
                            }
                            else if (to == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoSqYd(fromnum));
                            }
                            else if (to == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoSqFt(fromnum));
                            }
                            else if (to == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoSqIn(fromnum));
                            }
                            else if (to == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                // Console.WriteLine(func.SqMtoHec(fromnum));
                            }
                            else if (to == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMtoAcre(fromnum));
                            }
                        }
                        else if (from == "SqMi")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoSqM(fromnum));
                            }
                            else if (from == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoSqYd(fromnum));
                            }
                            else if (from == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoSqFt(fromnum));
                            }
                            else if (from == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoSqIn(fromnum));
                            }
                            else if (from == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoHec(fromnum));
                            }
                            else if (from == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqMitoAcre(fromnum));
                            }
                        }
                        else if (from == "SqYd")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoSqM(fromnum));
                            }
                            else if (from == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoSqMi(fromnum));
                            }
                            else if (from == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoSqFt(fromnum));
                            }
                            else if (from == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoSqIn(fromnum));
                            }
                            else if (from == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoHec(fromnum));
                            }
                            else if (from == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqYdtoAcre(fromnum));
                            }
                        }
                        else if (from == "SqFt")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoSqM(fromnum));
                            }
                            else if (from == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoSqMi(fromnum));
                            }
                            else if (from == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoSqYd(fromnum));
                            }
                            else if (from == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoSqIn(fromnum));
                            }
                            else if (from == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoHec(fromnum));
                            }
                            else if (from == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqFttoAcre(fromnum));
                            }
                        }
                        else if (from == "SqIn")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoSqM(fromnum));
                            }
                            else if (from == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoSqMi(fromnum));
                            }
                            else if (from == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoSqFt(fromnum));
                            }
                            else if (from == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoSqFt(fromnum));
                            }
                            else if (from == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoHec(fromnum));
                            }
                            else if (from == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.SqIntoAcre(fromnum));
                            }
                        }
                        else if (from == "Hec")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                // Console.WriteLine(func.HectoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                // Console.WriteLine(func.HectoSqM(fromnum));
                            }
                            else if (from == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HectoSqMi(fromnum));
                            }
                            else if (from == "SqYd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HectoSqFt(fromnum));
                            }
                            else if (from == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HectoSqFt(fromnum));
                            }
                            else if (from == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HectoSqIn(fromnum));
                            }
                            else if (from == "Acre")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HectoAcre(fromnum));
                            }
                        }
                        else if (from == "Acre")
                        {
                            Console.Write("what are converting to: ");
                            string to = Console.ReadLine();
                            if (from == "SqKm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqKm(fromnum));
                            }
                            else if (from == "SqM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqM(fromnum));
                            }
                            else if (from == "SqMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqMi(fromnum));
                            }
                            else if (from == "Sqyd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqYd(fromnum));
                            }
                            else if (from == "SqFt")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqFt(fromnum));
                            }
                            else if (from == "SqIn")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoSqIn(fromnum));
                            }
                            else if (from == "Hec")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.AcretoHec(fromnum));
                            }

                        }
                    }
                    else if (convertType == "Energy")
                    {
                        Console.Write("what are you converting from:");
                        string from = Console.ReadLine();
                        if (from == "J")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                // Console.WriteLine(func.JtoKJ(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.JtoFtLb(fromnum));
                            }
                        }
                        else if (from == "Kj")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                // Console.WriteLine(func.KjtoJ(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KjtoFtLb(fromnum));
                            }
                        }
                        else if (from == "Gc")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoKj(fromnum));
                            }
                            // else if (to == "Kc")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.GctoKc(fromnum));
                            // }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GctoFtLb(fromnum));
                            }
                        }
                        else if (from == "Kc")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoKj(fromnum));
                            }
                            // else if (to == "Gc")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.KctoGc(fromnum));
                            // }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KctoFtLb(fromnum));
                            }
                        }
                        else if (from == "WzHr")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoGc(fromnum));
                            }
                            // else if (to == "Kc")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.WzHrtoKc(fromnum));
                            // }
                            // else if (to == "KwHr")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.WzHrtoKwHr(fromnum));
                            // }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.WzHrtoFtlb(fromnum));
                            }
                        }
                        else if (from == "KwHr")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoKc(fromnum));
                            }
                            // else if (to == "WzHr")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.KwHrtoWzHr(fromnum));
                            // }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KwHrtoFtLb(fromnum));
                            }
                        }
                        else if (from == "Ev")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoKwHr(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoBTU(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.EvtoFtLb(fromnum));
                            }
                        }
                        else if (from == "BTU")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoEv(fromnum));
                            }
                            else if (to == "UST")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoUST(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.BTUtoFtLb(fromnum));
                            }
                        }
                        else if (from == "UST")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoBTU(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.USTtoFtLb(fromnum));
                            }
                        }
                        else if (from == "FtLb")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "J")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoJ(fromnum));
                            }
                            else if (to == "Kj")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoKj(fromnum));
                            }
                            else if (to == "Gc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoGc(fromnum));
                            }
                            else if (to == "Kc")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoKc(fromnum));
                            }
                            else if (to == "WzHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoWzHr(fromnum));
                            }
                            else if (to == "KwHr")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoKwHr(fromnum));
                            }
                            else if (to == "Ev")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoEv(fromnum));
                            }
                            else if (to == "BTU")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoBTU(fromnum));
                            }
                            else if (to == "FtLb")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.FtLbtoUST(fromnum));
                            }
                        }
                    }
                    else if (convertType == "Frequency")
                    {
                        Console.Write("what are you converting from:");
                        string from = Console.ReadLine();
                        if (from == "Hz")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "KHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.Dtenthousand(fromnum));
                            }
                            else if (to == "MHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HztoMHz(fromnum));
                            }
                            else if (to == "GHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.HztoGHz(fromnum));
                            }
                        }
                        else if (from == "KHz")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Hz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "MHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.Dthousand(fromnum));
                            }
                            else if (to == "GHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KHztoGHz(fromnum));
                            }
                        }
                        else if (from == "MHz")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Hz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MHztoHz(fromnum));
                            }
                            else if (to == "KHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "GHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.Dthousand(fromnum));
                            }
                        }
                        else if (from == "GHz")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Hz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GHztoHz(fromnum));
                            }
                            else if (to == "KHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.GHztoKHz(fromnum));
                            }
                            else if (to == "MHz")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                        }
                    }
                    else if (convertType == "Length")
                    {
                        Console.Write("what are you converting from:");
                        string from = Console.ReadLine();
                        if (from == "Km")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "M")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "Cm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoCm(fromnum));
                            }
                            else if (to == "Mm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoMm(fromnum));
                            }
                            else if (to == "MicroM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoMicroM(fromnum));
                            }
                            else if (to == "Nm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoNm(fromnum));
                            }
                            else if (to == "Mi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoMi(fromnum));
                            }
                            else if (to == "Yd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoYd(fromnum));
                            }
                            else if (to == "Ft")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoFt(fromnum));
                            }
                            else if (to == "In")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoIn(fromnum));
                            }
                            else if (to == "NautMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.KmtoNautMi(fromnum));
                            }
                        }
                        else if (from == "M")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Km")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "Cm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xonehundo(fromnum));
                            }
                            else if (to == "Mm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoMm(fromnum));
                            }
                            else if (to == "MicroM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoMicroM(fromnum));
                            }
                            else if (to == "Nm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoNm(fromnum));
                            }
                            else if (to == "Mi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoMi(fromnum));
                            }
                            else if (to == "Yd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoYd(fromnum));
                            }
                            else if (to == "Ft")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoFt(fromnum));
                            }
                            else if (to == "In")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoIn(fromnum));
                            }
                            else if (to == "NautMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MtoNautMi(fromnum));
                            }
                        }
                        else if (from == "Cm")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Km")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoKm(fromnum));
                            }
                            else if (to == "M")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xonehundo(fromnum));
                            }
                            else if (to == "Mm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xten(fromnum));
                            }
                            else if (to == "MicroM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xtenthousand(fromnum));
                            }
                            else if (to == "Nm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoNm(fromnum));
                            }
                            else if (to == "Mi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoMi(fromnum));
                            }
                            else if (to == "Yd")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoYd(fromnum));
                            }
                            else if (to == "Ft")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoFt(fromnum));
                            }
                            else if (to == "In")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoIn(fromnum));
                            }
                            else if (to == "NautMi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.CmtoNautMi(fromnum));
                            }
                        }
                        else if (from == "Mm")
                        {
                            Console.Write("what are you converting to: ");
                            string to = Console.ReadLine();
                            if (to == "Km")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MmtoKm(fromnum));
                            }
                            else if (to == "M")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "Cm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xten(fromnum));
                            }
                            else if (to == "MicroM")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.xthousand(fromnum));
                            }
                            else if (to == "Nm")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MmtoNm(fromnum));
                            }
                            else if (to == "Mi")
                            {
                                Console.Write("What number are you converting from: ");
                                double fromnum = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine(func.MmtoMi(fromnum));
                            }
                            // else if (to == "Yd")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.(fromnum));
                            // }
                            // else if (to == "Ft")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.(fromnum));
                            // }
                            // else if (to == "In")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.(fromnum));
                            // }
                            // else if (to == "NautMi")
                            // {
                            //     Console.Write("What number are you converting from: ");
                            //     double fromnum = Convert.ToDouble(Console.ReadLine());
                            //     Console.WriteLine(func.(fromnum));
                            // }
                        }
                        // else if (from == "MicroM")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoKc(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoKwHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoEv(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoBTU(fromnum));
                        //     }
                        //     else if (to == "UST")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoUST(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(WzHrtoFtlb(fromnum));
                        //     }
                        // }
                        // else if (from == "Nm")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoWzHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoEv(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoBTU(fromnum));
                        //     }
                        //     else if (to == "UST")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoUST(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(KwHrtoFtLb(fromnum));
                        //     }
                        // }
                        // else if (from == "Mi")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoWzHr(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoKwHr(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoBTU(fromnum));
                        //     }
                        //     else if (to == "UST")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoUST(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(EvtoFtLb(fromnum));
                        //     }
                        // }
                        // else if (from == "Yd")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoWzHr(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoKwHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoEv(fromnum));
                        //     }
                        //     else if (to == "UST")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoUST(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(BTUtoFtLb(fromnum));
                        //     }
                        // }
                        // else if (from == "Ft")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoWzHr(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoKwHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoEv(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoBTU(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(USTtoFtLb(fromnum));
                        //     }
                        // }
                        // else if (from == "In")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoWzHr(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKwHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoEv(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoBTU(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoUST(fromnum));
                        //     }
                        // }
                        // else if (from == "NautMi")
                        // {
                        //     Console.Write("what are you converting to: ");
                        //     string to = Console.ReadLine();
                        //     if (to == "J")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoJ(fromnum));
                        //     }
                        //     else if (to == "Kj")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKj(fromnum));
                        //     }
                        //     else if (to == "Gc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoGc(fromnum));
                        //     }
                        //     else if (to == "Kc")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKc(fromnum));
                        //     }
                        //     else if (to == "WzHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoWzHr(fromnum));
                        //     }
                        //     else if (to == "KwHr")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoKwHr(fromnum));
                        //     }
                        //     else if (to == "Ev")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoEv(fromnum));
                        //     }
                        //     else if (to == "BTU")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoBTU(fromnum));
                        //     }
                        //     else if (to == "FtLb")
                        //     {
                        //         Console.Write("What number are you converting from: ");
                        //         double fromnum = Convert.ToDouble(Console.ReadLine());
                        //         Console.WriteLine(FtLbtoUST(fromnum));
                        //     }
                        // }
                    }
                    else if (convertType == "Mass")
                    {

                    }
                    else if (convertType == "Pressure")
                    {

                    }
                    else if (convertType == "Speed")
                    {

                    }
                    else if (convertType == "Temp")
                    {

                    }
                    else if (convertType == "Time")
                    {

                    }
                    else if (convertType == "Volume")
                    {

                    }
                }
                else if (userinput == "exit")
                {
                    repeat = false;
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Thats not a command!");
                }
            }
        }
    }
}
