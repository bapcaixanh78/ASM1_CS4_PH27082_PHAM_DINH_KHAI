using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM1.Models
{
    public class Supplier
    {
        public Guid IdSupplier { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public string Address { get; set; }

        public int Status { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}
