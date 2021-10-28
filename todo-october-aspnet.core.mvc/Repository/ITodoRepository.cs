using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_october_aspnet.core.mvc.Models;

namespace todo_october_aspnet.core.mvc.Repository
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> GetAllAsync();
        Task<Todo> GetByIdAsync(int Id);
        Task<Todo> AddAsync(Todo todo);
        void Delete(int Id);

    }
}
