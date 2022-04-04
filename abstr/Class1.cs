using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstr
{
    internal abstract class Person
    {
        public abstract int age();
        public abstract string name();
    }

    internal class Teacher : Person
    {
        private String Lesson;

        public override int age()
        {
            throw new NotImplementedException();
        }

        public override string name()
        {
            throw new NotImplementedException();
        }
    }

    internal class Student : Person
    {
        private int Course;

        public override int age()
        {
            throw new NotImplementedException();
        }

        public override string name()
        {
            throw new NotImplementedException();
        }
    }

    internal class ZavKaf : Person
    {
        private String Kaf;

        public override int age()
        {
            throw new NotImplementedException();
        }

        public override string name()
        {
            throw new NotImplementedException();
        }
    }
}
