using System;
using System.Collections.Generic;

namespace TestApp.Models
{
    public class Result
    {
        public string id { get; set; }
        public string accountType { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string userStatus { get; set; }
        public string jobTitle { get; set; }
        public DateTime dateOfLastLogin { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    
}
