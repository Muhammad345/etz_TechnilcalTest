using System.Linq;
using ETZ.Data;
using ETZ.Models;
using Microsoft.EntityFrameworkCore;

namespace ETZ.Repository
{ 
public class EmployeeRepo : IRepo<Employee>
{
    private readonly AppDbContext _appDbContext;

    public EmployeeRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public bool Create(Employee entity)
    {
        _appDbContext.Employees.Add(entity);
        _appDbContext.SaveChanges();

        return true;
    }

    public bool Delete(int key)
    {
        var firestation = _appDbContext.Employees.Find(key);
        if (firestation == null)
        {
            return false;
        }

        _appDbContext.Employees.Remove(firestation);
        _appDbContext.SaveChanges();

        return true;
    }

    public IQueryable<Employee> GetAll()
    {
        return _appDbContext.Employees;
    }

    public Employee GetSpecific(int Id)
    {
        return _appDbContext.Employees.Find(Id);
    }

    public bool Update(int key, Employee entity)
    {
        _appDbContext.Entry(entity).State = EntityState.Modified;

        try
        {
            _appDbContext.SaveChanges();
        }
        catch (DbUpdateException e)
        {
            throw e;
        }

        return true;
    }

    private bool FirestationExists(int id)
    {
        return _appDbContext.Employees.Count(e => e.Id == id) > 0;
    }
}
}
