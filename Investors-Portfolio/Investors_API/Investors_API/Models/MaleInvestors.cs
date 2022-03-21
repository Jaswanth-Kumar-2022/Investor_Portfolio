using System;
using System.Collections.Generic;

namespace Investors_API.Models
{
    public partial class MaleInvestors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ProfilePic { get; set; }
        public decimal? Total_Investment { get; set; }
        public string Gender { get; set; }
    }
}
