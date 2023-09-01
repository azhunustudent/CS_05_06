namespace CS_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan", "Ivanov", "Ivanovich", "SEP-222.1", 18);

            int[] programmingGrades = { 4, 5, 3, 4, 5, 5 };
            student.SetGradesP(programmingGrades);

            int[] administrationGrades = { 5, 4, 5, 5, 4 };
            student.SetGradesA(administrationGrades);

            int[] designGrades = { 5, 4, 4, 3, 4, 5, 4, 3 };
            student.SetGradesD(designGrades);

            student.Print();

            Console.WriteLine("---------------------------------");
            student.PrintGrades();

            Console.WriteLine("\n---------------------------------");
            student.PrintAVG();
        }
    }
}