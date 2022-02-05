using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr
{

    abstract class Person
    {
        public abstract void Age();

        public virtual void Name() 
        {
        }
    }

    class Student : Person
    {
        public override void Age()
        {
            Console.WriteLine("18");
        }

        public override void Name()
        {
            base.Name();
        }
    }

    class Teacher : Person
    {
        public override void Age()
        {
            Console.WriteLine("25+ Лет");
        }

        public void Lesson()
        {
            Console.WriteLine("Предмет - ");
        }
    }

    class ZavKaf : Person
    {
        public override void Age()
        {
            Console.WriteLine("30+ Лет");
        }

        public void Kafedra()
        {
            Console.WriteLine("Кафедра - ");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            ZavKaf zavKaf = new ZavKaf();

            teacher.Lesson();
            student.Name();
            student.Age();
        }
    }

}
