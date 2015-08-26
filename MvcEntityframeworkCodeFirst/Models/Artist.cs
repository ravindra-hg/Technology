using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEntityframeworkAndProfiling.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required()]
        [StringLength(100,MinimumLength=5)]
        public string Name { get; set; }
        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Location { get; set; }
    }
}