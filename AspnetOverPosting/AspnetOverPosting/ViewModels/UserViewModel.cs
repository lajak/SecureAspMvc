using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetOverPosting.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Role { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
