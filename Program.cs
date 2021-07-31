using System;

namespace StudentApplication
{
    public class Student
    {
        int _stuId = 0;
        string _firstName = "";
        string _lastName = "";
        decimal _loanAmount = 0;
        char _gender = '\0';
        bool _isNew = false;
        public Student(int studId, string firstName, string lastName, decimal loanAmount, char gender, bool isNew)
        {
            _stuId = studId;
            _firstName = firstName;
            _lastName = lastName;
            _loanAmount = loanAmount;
            _gender = gender;
            _isNew = isNew;
        }

        public void UpdateLoanAmount(decimal loanAmount)
        {
            _loanAmount = loanAmount;
        }

        public string StudentData()
        {
            string studentData = $"studId: {_stuId}, firstName: {_firstName}, loan amount: {_loanAmount}";
            return studentData;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int stuId = 0;
            string firstName = "";
            string lastName = "";
            decimal loanAmount = 0;
            char gender = '\0';
            bool isNew = false;

            Console.WriteLine("Please enter the student Id");

            stuId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the student's firstname: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the student's lastname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter the student's loan amount: ");
            loanAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the student's gender ('f' = female, 'm' = male): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The student is a new student (true/false): ");
            isNew = Convert.ToBoolean(Console.ReadLine());

            Student student = new Student(stuId, firstName, lastName, loanAmount, gender, isNew);

            Console.Clear();

            Student studentCopy = student;
            Console.WriteLine("Student data " + student.StudentData());
            Console.WriteLine();

            Console.WriteLine("Student copy data " + studentCopy.StudentData());
            Console.WriteLine();

            Console.WriteLine("Please update the student's loan amount: ");
            student.UpdateLoanAmount(Convert.ToDecimal(Console.ReadLine()));

            string dividerText = "After loan update";

            Console.WriteLine(new string ('-', dividerText.Length));
            Console.WriteLine(dividerText);
            Console.WriteLine(new string('-', dividerText.Length));

            
            Console.WriteLine("Student data " + student.StudentData());
            Console.WriteLine();

            Console.WriteLine("Student copy data " + studentCopy.StudentData());
           
        }
    }
}
