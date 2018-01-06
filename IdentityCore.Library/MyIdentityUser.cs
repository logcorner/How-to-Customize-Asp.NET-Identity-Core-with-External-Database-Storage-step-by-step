namespace IdentityCore.Library
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class MyIdentityUser : IdentityUser
    {
        public DateTime? JoinDate { get; set; }
        public string JobTitle { get; set; }
        public string Contract { get; set; }

        public MyIdentityUser()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}