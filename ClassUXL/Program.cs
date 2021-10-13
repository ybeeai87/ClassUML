using System;
using System.Collections.Generic;

namespace ClassUXL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>
            {
                new Student("Johnny", "450 Clover St.", "Computer Science", 2022, 34000),
                new Student("Rebecca", "123 Sunshine Dr.", "Applied Quantom Physics", 2024, 76000),
                new Student("Yousif", "13 Oak Tree Way", "Philosophy", 2026, 43500),
                new Staff("Yoda", "1 Jedi Avenue", "Jedi Academy", 0),
                new Staff("Boba Fett", "27 Mandalorian Way", "Bounty Hunter University", 80000)
            };
            foreach (Person p in person)
            {
                Console.WriteLine(p.ToString());
            }
            bool runProgram = true;
            int studentYear = 0000;
            double studentFee = 0000;
            double staffPay = 000;

            while (runProgram)
            {
                Console.WriteLine("Would you like to add a student or staff member? y/n");
                string addPerson = Console.ReadLine().ToLower().Trim();
                if (addPerson == "y")
                {
                    Console.WriteLine("Would you like to add student or staff? student/staff");
                    string yesAdd = Console.ReadLine().ToLower().Trim();
                    if (yesAdd == "student")
                    {
                        Console.WriteLine("Please enter their name.");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Please enter their address.");
                        string studentAddress = Console.ReadLine();
                        Console.WriteLine("Please enter their program.");
                        string studentProgram = Console.ReadLine();
                        Console.WriteLine("Please enter their year.");
                        while (true)
                        {
                            try
                            {
                                studentYear = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message + " Please try again.");
                            }
                        }
                        Console.WriteLine("Please enter their fee.");
                        while (true)
                        {
                            try
                            {
                                studentFee = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message + " Please try again.");
                            }
                        }
                        Student s1 = new Student(studentName, studentAddress, studentProgram, studentYear, studentFee);
                        person.Add(s1);
                        Console.WriteLine(s1.ToString());
                    }
                    else if (yesAdd == "staff")
                    {
                        Console.WriteLine("Please enter their name.");
                        string staffName = Console.ReadLine();
                        Console.WriteLine("Please enter their address.");
                        string staffAddress = Console.ReadLine();
                        Console.WriteLine("Please enter their school.");
                        string staffSchool = Console.ReadLine();
                        Console.WriteLine("Please enter their pay.");
                        while (true)
                        {
                            try
                            {
                                staffPay = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message + " Please try again.");
                            }
                        }
                        Staff st1 = new Staff(staffName, staffAddress, staffSchool, staffPay);
                        person.Add(st1);
                        Console.WriteLine(st1.ToString());
                        runProgram = true;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid option.");
                        runProgram = true;
                    }
                }
                else if (addPerson == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid option");
                }
                runProgram = Validator.Validator.getContinue();
                while (true)
                {
                    Console.WriteLine("Would you like to view the whole roster? y/n");
                    string viewRoster = Console.ReadLine();
                    if (viewRoster == "y")
                    {
                        foreach (Person p in person)
                        {
                            Console.WriteLine(p.ToString());
                        }
                        break;
                    }
                    else if (viewRoster == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid option. Try again.");
                    }
                }
            }
        }
    }
}
