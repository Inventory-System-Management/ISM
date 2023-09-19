using ISM.Application.Interfaces.Materials;
using ISM.Domain.Models;
using ISM.Infrastructure.ISMDbcontext;

namespace ISM.Infrastructure.Validation;

public class ValidationforMaterial:IMaterialValidation
{
    private ISMdbcontext _dbcontext;
    public ValidationforMaterial()
    {
        _dbcontext = new();
    }

    public bool Create(Material objectname)
    {
        if (objectname == null)
            return false;
        return true;
    }

    public bool Delete(int Id)
    {
        var deletedobject = _dbcontext.Materials.Select(x => x).Where(x => x.Id == Id);
        if (deletedobject.Any())
            return true;
        return false;
    }

    public bool Getall()
    {
        List<Material> list = _dbcontext.Materials.ToList();
        if (list.Count > 0) return true;
        return false;
    }

    public bool Getby(int Id)
    {
        Material material = _dbcontext.Materials.Select(x => x).Where((x) => x.Id == Id).First();
        if (material != null) return true;
        return false;
    }

    public bool Update(Material objectname)
    {
        var Updateobject = _dbcontext.Materials.Find(objectname.Id);
        if (Updateobject != null)
            return true;
        return false;
    }

 }
