using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_october_aspnet.core.mvc.Models;

namespace todo_october_aspnet.core.mvc.Repository
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAll();
        Task<Todo> GetById(int Id);
        Task<Todo> AddEntity(Todo todo);
        void Delete(int Id);

    }
}
