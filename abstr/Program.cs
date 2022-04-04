using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        teacher.Age = 30;
        teacher.Name = "Ольга";
        teacher.Lesson = "Физика";

        Student student = new Student();
        student.Age = 18;
        student.Name = "Иван";
        student.Course = 1;

        ZavKaf zavkaf = new ZavKaf();
        zavkaf.Age = 18;
        zavkaf.Name = "Иван";
        zavkaf.Kaf = "Экономики";
    }
}



