using System;

namespace CS_05_06
{
    public class Student
    {
        // Поля - переменные
        private string firstName;
        private string lastName;
        private string midName;     // отество
        private string group;
        private int    age;
        // массивы оценк студента
        private int[]  gradesP;      // программирование
        private int[]  gradesA;      // администрирование
        private int[]  gradesD;      // дизайн


        // Констуркторы
        public Student() { }

        public Student(string firstName, string lastName, string midName, string group, int age)
            : this()
        {
            FirstName = firstName;
            LastName  = lastName;
            MidName   = midName;
            Group     = group;
            Age       = age;
        }


        // Свойства
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName  { get { return lastName; } set { lastName = value; } }
        public string MidName   { get { return midName; } set { midName = value; } }
        public string Group     { get { return group; } set { group = value; } }
        public int    Age       { get { return age; } set { age = value; } }


        // Методы
        // метод для установки и получения оценок
        public int[] GetGradesP() { return gradesP; }
        public void SetGradesP(int[] values)
        {
            gradesP = values;
        }

        public int[] GetGradesA() { return gradesA; }
        public void SetGradesA(int[] values)
        {
            gradesA = values;
        }

        public int[] GetGradesD() { return gradesA; }
        public void SetGradesD(int[] values)
        {
            gradesD = values;
        }

        // полуение среднего балла по заданному предмету
        public double GetAvgGradeP()
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < gradesP.Length; i++)
            {
                sum += gradesP[i];
            }
            return avg = (double)sum / gradesP.Length;
        }

        public double GetAvgGradeA()
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < gradesA.Length; i++)
            {
                sum += gradesA[i];
            }
            return avg = (double)sum / gradesA.Length;
        }

        public double GetAvgGradeD()
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < gradesD.Length; i++)
            {
                sum += gradesD[i];
            }
            return avg = (double)sum / gradesD.Length;
        }

        // методы печати/вывода информации на консоль: информация о студенте,
        // оценки и средний балл
        public void Print()
        {
            Console.WriteLine("Information about student:");
            Console.WriteLine($"Name: {FirstName}\nSurname: {LastName}\nMiddle Name: {MidName}\n" +
                              $"Age: {Age}\nGroupName: {Group}");
        }

        public void PrintGrades()
        {
            Console.WriteLine("Grades of Programming:");
            foreach (int grade in gradesP)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\nGrades of Administration:");
            foreach (int grade in gradesA)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine("\nGrades of Design:");
            foreach (int grade in gradesD)
            {
                Console.Write(grade + " ");
            }
        }

        public void PrintAVG()
        {
            Console.WriteLine("AVG Grades of Programming: " + GetAvgGradeP());
            Console.WriteLine("AVG Grades of Administration: " + GetAvgGradeA());
            Console.WriteLine("AVG Grades of Design: " + GetAvgGradeD());
        }
    }
}
