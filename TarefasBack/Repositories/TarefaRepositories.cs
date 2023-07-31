using TarefasBack.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TarefasBack.Repositories
{

public interface ITarefaRepositories 
{
    
    List<Tarefa> Read();
    void Create(Tarefa tarefa);
    void Delete(Guid id);
    void Update(Tarefa tarefa);


   
}

public class TarefaRepositories : ITarefaRepositories
{
    private readonly DataContext _context;


    public TarefaRepositories(DataContext context){
        
        _context = context;
    }
     public void Create(Tarefa tarefa)
        {
            tarefa.id = Guid.NewGuid();
            _context.Add(tarefa);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var tarefa = _context.Tarefas.Find(id);
            _context.Entry(tarefa).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<Tarefa> Read()
        {
           return _context.Tarefas.ToList();
        }

        public void Update(Tarefa tarefa)
        {

            _context.Entry(tarefa).State = EntityState.Modified;
            _context.SaveChanges();
          

            
        }
    }
}




    

       