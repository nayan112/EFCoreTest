using System;

namespace UserDomain.Entity
{
    public class Users
    {
        public Users(string id, string name, string email)//, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            //BirthDate = birthDate;
        }

        // Empty constructor for EF
        protected Users() { }
        public string Id { get; private set; }
        public string Name { get; private set; }

        public string Email { get; private set; }

        //public DateTime BirthDate { get; private set; }
    }
}