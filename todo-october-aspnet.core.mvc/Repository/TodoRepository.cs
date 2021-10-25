using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_october_aspnet.core.mvc.Models;

namespace todo_october_aspnet.core.mvc.Repository
{
    public class TodoRepository : ITodoRepository
    {
        protected readonly DbContext _context;
        private DbSet<Todo> _dbSet;

        public TodoRepository(TodoAppOctoberDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<Todo>();
        }

        public async Task<Todo> AddEntity(Todo todo)
        {
            await _dbSet.AddAsync(todo);
            await _context.SaveChangesAsync();
            return todo;
        }

        public void Delete(int Id)
        {
            var todo = GetById(Id).Result;
            _dbSet.Remove(todo);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Todo>> GetAll()
        {
            return await _dbSet.ToListAsync();

        }

        public async  Task<Todo> GetById(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }
    }
}
