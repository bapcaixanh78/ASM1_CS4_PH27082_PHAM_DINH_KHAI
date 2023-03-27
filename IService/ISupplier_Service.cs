using ASM1.Models;

namespace ASM1.IService
{
    public interface ISupplier_Service
    {
        public bool AddSP(Supplier s);
        public bool UpdateSP(Supplier s);
        public bool DeleteSP(Guid s);
        public List<Supplier> GetAllSP();
        public Supplier GetSupplierByID(Guid id);
        public List<Supplier> GetSupplierByName(string name);
        public List<Supplier> GetSupplier5();
    }
}
