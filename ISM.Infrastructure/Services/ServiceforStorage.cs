using ISM.Application.Interfaces.Storages;
using ISM.Domain.Models;
using ISM.Infrastructure.Repositories;

namespace ISM.Infrastructure.Services;

public class ServiceforStorage : IStorageService
{
    private IStorageRepository _repository;
    public ServiceforStorage() => _repository = new RepositoryforStorage();
    public Storage Create(Storage Objectname)
    {
        _repository.Create(Objectname);
        return Objectname;
    }

    public int Delete(int id)
    {
        _repository.Delete(id);
        return id;
    }

    public IEnumerable<Storage> GetAll()
    {
        return _repository.GetAll();
    }

    public Storage Getbyid(int id)
    {
        return _repository.Getbyid(id);
    }

    public bool Update(Storage objectname)
    {
        return _repository.Update(objectname);
    }
}
