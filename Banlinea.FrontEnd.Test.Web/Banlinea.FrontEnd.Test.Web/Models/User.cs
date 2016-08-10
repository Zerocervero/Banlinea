using System;

namespace Banlinea.FrontEnd.Test.Web.Models
{
    public class User : IBusinessEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}