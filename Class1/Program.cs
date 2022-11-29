namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Ayxan", "Mustafayev", 1, 95, true);
            
            Student student2 = new Student("Nicat", "Aliyev", 3, 48, false);

            
            student1.FullName();
            student2.FullName();
            
            student1.AllValues();
            student2.AllValues();

            student1.NextExam();
            student2.NextExam();

        }
    }
}