using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.BLL
{
    public class User
    {
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

        public List<Quiz> QuizesCreated { get; set; }
        public List<User> QuizesAttended { get; set; }
    }
}
