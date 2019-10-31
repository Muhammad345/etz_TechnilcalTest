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
        var employee = GetSpecific(key);
        if (employee == null)
        {
            return false;
        }

        _appDbContext.Employees.Remove(employee);
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
}
}
