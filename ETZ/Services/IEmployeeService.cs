using System.Collections.Generic;
using ETZ.ViewModel;

namespace ETZ.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee_Listing> GetEmployee_Listing();
    }
}
