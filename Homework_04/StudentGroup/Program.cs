using System;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5];
            string[] studentsG2 = new string[5];

            Console.WriteLine("Enter the names of the students in group G1.");
            for (int i = 0; i < studentsG1.Length; i++)
            {
                Console.Write($"Enter student number {i + 1} : ");
                string studentName = Console.ReadLine();
                studentsG1[i] = studentName;
            }

            Console.WriteLine("\nEnter the names of the students in group G2.");
            for (int i = 0; i < studentsG2.Length; i++)
            {
                Console.Write($"Enter student number {i + 1} : ");
                string studentName = Console.ReadLine();
                studentsG2[i] = studentName;
            }

            while (true)
            {
                Console.WriteLine("Print student list.");
                Console.Write("Enter group number to print its students (1.G1 , 2.G2): ");
                string groupNum = Console.ReadLine();

                if (groupNum == "1")
                {
                    while (true)
                    {
                        Console.Write("Would you like to insert another student (y/any) ?");
                        string input = Console.ReadLine();
                        if (input.ToLower() != "y")
                        {
                            Console.WriteLine("G1 students :");
                            for (int i = 0; i < studentsG1.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}.{studentsG1[i]}");
                            }
                            break;
                        }
                        Console.Write($"Enter student number {studentsG1.Length + 1} : ");
                        string studentName = Console.ReadLine();
                        Array.Resize(ref studentsG1, studentsG1.Length + 1);
                        studentsG1[studentsG1.Length - 1] = studentName;
                        continue;
                    }
                    break;
                }

                else if (groupNum == "2")
                {
                    while (true)
                    {
                        Console.Write("Would you like to insert another student (y/any) ?");
                        string input = Console.ReadLine();
                        if (input.ToLower() != "y")
                        {
                            Console.WriteLine("G2 students :");
                            for (int i = 0; i < studentsG2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}.{studentsG2[i]}");
                            }
                            break;
                        }
                        Console.Write($"Enter student number {studentsG2.Length + 1} : ");
                        string studentName = Console.ReadLine();
                        Array.Resize(ref studentsG2, studentsG2.Length + 1);
                        studentsG2[studentsG2.Length - 1] = studentName;
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("There is not a group with that number");
                    continue;
                }
            }
        }
    }
}
