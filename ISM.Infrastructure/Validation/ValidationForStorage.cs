using ISM.Application.Interfaces.Storages;
using ISM.Domain.Models;
using ISM.Domain.States;
using ISM.Infrastructure.ISMDbcontext;


namespace ISM.Infrastructure.Validation;

public class ValidationForStorage : IStorageValidation
{
    private ISMdbcontext _dbcontext;
    public ValidationForStorage() => _dbcontext = new();


    public bool Create(Storage objectname)
    {
        if (objectname == null)
            return false;
        return true;
    }

    public bool Delete(int Id)
    {
        var deletedobject = _dbcontext.Orders.Select(x => x).Where(x => x.Id == Id);
        if (deletedobject.Count() > 0)
            return true;
        return false;
    }

    public bool Getall()
    {
        List<Storage> list = _dbcontext.Storages.ToList();
        if (list.Count > 0) return true;
        return false;
    }

    public bool Getby(int Id)
    {
        Storage storage = _dbcontext.Storages.Select(x => x).Where((x) => x.Id == Id).First();
        if (storage != null) return true;
        return false;
    }

    public bool Update(Storage objectname)
    {
        var Updateobject = _dbcontext.Storages.Find(objectname.Id);
        if (Updateobject != null)
            return true;
        return false;
    }
}
