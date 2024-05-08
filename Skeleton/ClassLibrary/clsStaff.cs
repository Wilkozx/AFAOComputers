using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PayeeDetails { get; set; }
        public bool HasPerms { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime ContractExpiary { get; set; }
    }
}