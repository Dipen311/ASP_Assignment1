using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlanketApp.Models
{
    public class Blanket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
