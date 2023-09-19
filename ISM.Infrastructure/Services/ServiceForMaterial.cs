using ISM.Application.Interfaces.Materials;
using ISM.Domain.Models;
using ISM.Infrastructure.Repositories;

namespace ISM.Infrastructure.Services;

public class ServiceForMaterial
{
    private IMaterialRepository _repository;
    public ServiceForMaterial() => _repository = new RepositoryforMaterial();
    public Material Create(Material Objectname)
    {
        return _repository.Create(Objectname);
    }

    public int Delete(int id)
    {
        
        return _repository.Delete(id);
    }

    public IEnumerable<Material> GetAll()
    {
        return _repository.GetAll();
    }
    public Material Getbyid(int id)
    {
        return _repository.Getbyid(id);
    }

    public bool Update(Material objectname)
    {
        return _repository.Update(objectname);
    }
}

