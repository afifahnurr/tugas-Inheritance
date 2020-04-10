using System;
namespace Const
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, string idguru, string subjek)
            : base(name, age)
        {
            TeacherId = idguru;
            Subject = subjek;
        }
        public string TeacherId { get; set; }
        public string Subject { get; set; }
    }
}
