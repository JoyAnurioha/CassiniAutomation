using System;

namespace CassiniAutomationProject.Utilities
{
    public static class Utility
    {
        public static readonly string Email = "ieso.digital+joyprivacypatient4@gmail.com";
        public static readonly string Password = "Logarp44";
        public static readonly string URL = "https://member-int.thinkwell.co.uk";

        public static string GenerateEmail()
        {
            var time = DateTime.Now;
            var username = "NewPatient";
            var formattedTIme = time.ToString("yyyyMMddhhmmss");
            var email = "ieso.digital+" + username + formattedTIme + "@gmail.com";
            return email;
        }
    }
}
