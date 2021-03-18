using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer
    {
        public long NationalityId { get; set; }
        public int GamerId { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }


    }
}
