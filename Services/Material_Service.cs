using ASM1.IService;
using ASM1.Models;

namespace ASM1.Services
{
    public class Material_Service : IMaterial_Service
    {
        ShopDbcontext _Shopdb;
        public Material_Service()
        {
            _Shopdb = new ShopDbcontext();
        }

        public bool AddMT(Material m)
        {
            try
            {
                _Shopdb.Materials.Add(m);
                _Shopdb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMT(Guid id)
        {
            try
            {
                var ma = GetAllMT().FirstOrDefault(c => c.IdMaterial == id);
                _Shopdb.Materials.Remove(ma);
                _Shopdb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Material> GetAllMT()
        {
            return _Shopdb.Materials.ToList();
        }

        public Material GetMaterialByID(Guid id)
        {
            return GetAllMT().FirstOrDefault(c => c.IdMaterial == id);
        }

        public List<Material> GetMaterialByName(string name)
        {
            return GetAllMT().Where(c=>c.Name.Contains(name)).ToList();
        }

        public bool UpdateMT(Material m)
        {
            try
            {
                var x = GetMaterialByID(m.IdMaterial);
                x.IdMaterial = m.IdMaterial;
                x.Name = m.Name;
                x.Status = m.Status;
                x.Price = m.Price;
                x.Supplier = m.Supplier;
                x.Code = m.Code;
                _Shopdb.Materials.Update(x);
                _Shopdb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
