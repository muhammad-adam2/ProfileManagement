using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManagement.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string MaritalStatus { get; set; }
        public string DOM { get; set; }
    }
}
