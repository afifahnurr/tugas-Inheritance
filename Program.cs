using System;

namespace Const
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("amil", 22);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Ana", 25, "4233", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("raka", 19, "3242", "raka@amikom.ac.id");
            students.GetNameAndAge();

        }
    }
}
