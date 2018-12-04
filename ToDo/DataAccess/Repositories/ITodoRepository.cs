using Entities.Models;
using System.Collections.Generic;


namespace DataAccess.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo Find(long id);
        void Create(Todo todo);
        void Remove(long id);
        void Update(Todo todo);

        ToDoItem FindItem(long id);
        void AddItem(long todoId, ToDoItem item);
        void RemoveItem(long id);
        void UpdateItem(ToDoItem item);
    }
}
