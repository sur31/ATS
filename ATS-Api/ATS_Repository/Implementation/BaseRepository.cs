using ATS_DataAccess.Entities;
using ATS_Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ATS_Repository.Implementation
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity  
    {  
        private readonly ApplicationContext context;  
        private readonly DbSet<T> entities;  
        public BaseRepository(ApplicationContext context)  
        {  
            this.context = context;  
            entities = context.Set<T>();  
        }  
        public IEnumerable<T> GetAll()  
        {  
            return entities.AsEnumerable();  
        }  
        public T Get(int id)  
        {  
            return entities.SingleOrDefault(p =>p.Id  == id);  
        }  

        public int Add(T entity)  
        {  
            entities.Add(entity); 
            return context.SaveChanges(); 
        }  
    }  
}