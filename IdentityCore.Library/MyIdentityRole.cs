namespace IdentityCore.Library
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class MyIdentityRole<T> : IdentityRole<string>
    {
        public MyIdentityRole()
        {
            Id = Guid.NewGuid().ToString();
        }

        public MyIdentityRole(string name) : this()
        {
            Name = name;
        }

        public MyIdentityRole(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Description { get; internal set; }
    }
}