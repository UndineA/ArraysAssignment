using System;

namespace ArrayAssignment
{
    class ArrayAssignment
    {
        static void Main(string[] args)
        {
            byte[] grades = new byte[10];
            int i = 0;
            while (i < grades.Length)
            {
            Console.WriteLine("Please write the grade (0-10): ");
            byte gradeInput;
            if ((!Byte.TryParse(Console.ReadLine(), out gradeInput)) || (gradeInput < 0) || (gradeInput > 10))
                {
                Console.WriteLine("Wrong input! The grade should be an integer from 0 to 10.");
                return;
                }
            else 
                {
                grades[i] = gradeInput;
                }
            i++;
            }

            int failStudents = 0;
            Console.WriteLine("\nStudents who failed: ");
            for (int j = 0; j < grades.Length; j++)
            {
                if (grades[j] < 4)
                    failStudents += 1;
            }
            Console.Write(failStudents);

            int aStudents = 0;
            Console.WriteLine("\nStudents who got A: ");
            for (int j = 0; j < grades.Length; j++)
            {
                if (grades[j] == 10)
                aStudents += 1;
            }
            Console.Write(aStudents);

            int students0 = 0;
            int students1 = 0;
            int students2 = 0;
            int students3 = 0;
            int students4 = 0;
            int students5 = 0;
            int students6 = 0;
            int students7 = 0;
            int students8 = 0;
            int students9 = 0;
            int students10 = 0;
            for (int j = 0; j < grades.Length; j++)
            {
                if (grades[j] == 0)
                students0 += 1;
                else if (grades[j] == 1)
                students1 += 1;
                else if (grades[j] == 2)
                students2 += 1;
                else if (grades[j] == 3)
                students3 += 1;
                else if (grades[j] == 4)
                students4 += 1;
                else if (grades[j] == 5)
                students5 += 1;
                else if (grades[j] == 6)
                students6 += 1;
                else if (grades[j] == 7)
                students7 += 1;
                else if (grades[j] == 8)
                students8 += 1;
                else if (grades[j] == 9)
                students9 += 1;
                else if (grades[j] == 10)
                students10 += 1;
            }
            Console.WriteLine("\n\n" + students0 + " students with the grade 0");
            Console.WriteLine(students1 + " students with the grade 1");
            Console.WriteLine(students2 + " students with the grade 2");
            Console.WriteLine(students3 + " students with the grade 3");
            Console.WriteLine(students4 + " students with the grade 4");
            Console.WriteLine(students5 + " students with the grade 5");
            Console.WriteLine(students6 + " students with the grade 6");
            Console.WriteLine(students7 + " students with the grade 7");
            Console.WriteLine(students8 + " students with the grade 8");
            Console.WriteLine(students9 + " students with the grade 9");
            Console.WriteLine(students10 + " students with the grade 10");
        }

    }
}