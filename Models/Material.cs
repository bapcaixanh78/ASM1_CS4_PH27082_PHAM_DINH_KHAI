using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM1.Models
{
    public class Material
    {
        public Guid IdMaterial { get; set; }
        public string SupplierName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int AvailableQuantity { get; set; }
        public int Price { get; set; }

        public int Status { get; set; }

        public virtual Supplier Supplier { get; set; }

    }
}
