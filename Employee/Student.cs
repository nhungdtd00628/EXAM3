using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Student
    {
        private int _StudentId;
        private string _FirstName;
        private string _LastName;
        private string _PhoneNumber;
        private string _Email;

        public int studentId { get => _StudentId; set => _StudentId = value; }
        public string firstName { get => _FirstName; set => _FirstName = value; }
        public string lastName { get => _LastName; set => _LastName = value; }
        public string phoneNumber { get => _PhoneNumber; set => _PhoneNumber = value; }
        public string email { get => _Email; set => _Email = value; }
    }
}
