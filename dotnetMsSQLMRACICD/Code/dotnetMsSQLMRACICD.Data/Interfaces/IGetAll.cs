using System.Collections.Generic;

namespace dotnetMsSQLMRACICD.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
