using System;
namespace Const
{
    public class Students : Person
    {
        public Students(string name, int age, string idguru, string email)
            : base(name, age)
        {
            StudentId = idguru;
            Email = email;

        }
        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}
