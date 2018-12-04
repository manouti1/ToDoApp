using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Dao;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public void AddItem(long todoId, ToDoItem item)
        {
            throw new NotImplementedException();
        }

        public void Create(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public Todo Find(long id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id);
        }

        public ToDoItem FindItem(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos.ToList();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(long id)
        {
            var entity = _context.Todos.First(t => t.Id == id);
            _context.Todos.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Todo todo)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }

        public void UpdateItem(ToDoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
    }
}
