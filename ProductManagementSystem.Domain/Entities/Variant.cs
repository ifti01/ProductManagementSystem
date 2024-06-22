using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Specification { get; set; }
        public Size Size { get; set; }
    }
}
