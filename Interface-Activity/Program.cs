namespace Interface_XML
{
    public class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Student student = new Student();
            Employee employee = new Employee();

            admin.SetName("Maksuda", "Sultana");
            Console.WriteLine("The admin: " + admin.GetName());
            admin.Create();
            admin.Update();
            admin.Delete();

            student.SetName("Ckhyle", "Tamayo");
            Console.WriteLine("The student: " + student.GetName());
            student.Study();

            employee.SetName("Justin", "Neypes");
            Console.WriteLine("The employee: " + employee.GetName());
            employee.Teach();
            employee.AdminWork();
        }
    }
}