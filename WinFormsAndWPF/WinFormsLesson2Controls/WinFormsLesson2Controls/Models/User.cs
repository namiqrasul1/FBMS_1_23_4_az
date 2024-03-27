using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLesson2Controls.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public override string ToString() => $"{Name} {Surname} {Gender}";
    }
}
