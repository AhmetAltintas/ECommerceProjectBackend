using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        //Generic repository design pattern  --- genel depo tasarım deseni
        //Aynı işlemleri farklı objelerle yapacağımızda kullanırız.


        //Generic constraint genel kısıt 
        //Where T:class yaparak sadece class verilmesini sağladık yani herşey verilemez artık
        // ,IEntity ekleyerek de sadece IEntity classını ve onu implemente eden classları kullanılabilir hale getirdik
        // ,new() ekleyerek de sadece newlenebilir olanları seçilebilir yaptık yani soyut nesne olan IEntitynin kullanılmasını engelledik
        // artık sadece IEntityi implemente edenler seçilebilir oldu


        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
  