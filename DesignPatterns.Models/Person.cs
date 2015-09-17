using System;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    public class Person : IPerson, IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
