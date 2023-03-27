using ASM1.Models;

namespace ASM1.IService
{
    public interface IMaterial_Service
    {
        public bool AddMT(Material m);
        public bool UpdateMT(Material m);
        public bool DeleteMT(Guid id);
        public List<Material> GetAllMT();
        public Material GetMaterialByID(Guid id);
        public List<Material> GetMaterialByName(string name);
    }
}
