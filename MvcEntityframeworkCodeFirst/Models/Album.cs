using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEntityframeworkAndProfiling.Models
{
    public class Album
    {
        public int ID { get; set; }

        [Required()]
        [StringLength(200, MinimumLength = 2)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}