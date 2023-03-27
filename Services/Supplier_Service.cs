using ASM1.IService;
using ASM1.Models;

namespace ASM1.Services
{
    public class Supplier_service : ISupplier_Service
    {
        ShopDbcontext _shopDbcontext;

        public Supplier_service()
        {
            _shopDbcontext = new ShopDbcontext();
        }

        public bool AddSP(Supplier s)
        {
            try
            {
                _shopDbcontext.Suppliers.Add(s);
                _shopDbcontext.SaveChanges();
                return true;
            }
            catch {
                return false;
            }

        }

        public bool DeleteSP(Guid s)
        {
            try
            {
                var x = GetSupplierByID(s);
                _shopDbcontext.Suppliers.Remove(x);
                _shopDbcontext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Supplier> GetAllSP()
        {
            return _shopDbcontext.Suppliers.ToList();
        }


        public List<Supplier> GetSupplier5()
        {
            return GetAllSP().Where(c => c.Quantity > 5).ToList();
        }

        public Supplier GetSupplierByID(Guid id)
        {
            return GetAllSP().FirstOrDefault(c => c.IdSupplier == id);
        }

        public List<Supplier> GetSupplierByName(string name)
        {
            return GetAllSP().Where(c=>c.Name.Contains(name)).ToList();
        }

        public bool UpdateSP(Supplier s)
        {
            try
            {
                var x = GetSupplierByID(s.IdSupplier);
                x.IdSupplier = s.IdSupplier;
                x.Code = s.Code;
                x.Name = s.Name;
                x.Quantity = s.Quantity;
                x.Address = s.Address;
                x.Status = s.Status;
                _shopDbcontext.Suppliers.Update(x);
                _shopDbcontext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
