using System;

namespace ClassLibrary
{
    public class clsUser
    {
        public bool Active { get; set; }
        public DateTime DateofBirth { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
    }
}