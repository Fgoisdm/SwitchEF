using Switch.Domain.Enums;
using System;


namespace Switch.Domain.Entities
{
    public class User
    {

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string UrlPhoto { get; set; }
        public GenderEnum Gender { get; set; }


    }
}
