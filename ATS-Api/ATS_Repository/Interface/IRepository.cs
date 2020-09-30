using ATS_DataAccess.Entities;
using System.Collections.Generic;

namespace ATS_Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity  
    {  
        T Get(int id);  
        IEnumerable<T> GetAll();  
        int Add(T entity);
    }  
}