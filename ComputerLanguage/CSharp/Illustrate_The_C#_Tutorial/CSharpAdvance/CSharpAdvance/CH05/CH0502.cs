using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    delegate bool IsPass(Student stu);

    /// <summary>
    /// 委托理解：委托的使用增加了代码的灵活性
    /// </summary>
    class CH0502
    {
        public CH0502()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "a", Score = 60 });
            students.Add(new Student { Id = 2, Name = "b", Score = 40 });
            students.Add(new Student { Id = 3, Name = "2", Score = 90 });
            Print(students);
        }
        public static void Print(List<Student> students)
        {
            IsPass MyDel = new IsPass(Pass);

            foreach (Student student in students)
            {
                if (MyDel(student))
                {
                    Console.WriteLine($"student:{student.Id},{student.Name},{student.Score}");
                }
            }
        }
        static bool Pass(Student stu)
        {
            if (stu.Score >= 60)
                return true;
            else
                return false;
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
