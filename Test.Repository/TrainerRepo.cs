using MVCDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.Repository
{
    public class TrainerRepo : ITrainerRepo
    {
        private readonly Context context;
        public TrainerRepo()
        {
            context = new Context();
        }
        public void Add(Trainer data)
        {
            context.Trainer.Add(data);
            context.SaveChanges(); 
        }
        public Trainer GetById(int id)
        {

           return context.Trainer.Find(id);
        }
        //public void Delete(int id)
        //{
        //    var entity = context.Trainer.Find(id);
        //    context.Trainer.Remove(entity);
        //    context.SaveChanges();
        //}

        public List<Trainer> GetList()
        {
            var item= context.Trainer.ToList();
            return item;
        }

        public void Update(Trainer data)
        {
            var entity = GetById(data.Id);
            //entity.Name = data.Name;
            //entity.Address = data.Address;
            //entity.DateofBirth = data.DateofBirth;
            //entity.PhoneNumber = data.PhoneNumber;
            //context.SaveChanges();

            context.Entry(entity).State = EntityState.Detached;
            context.Trainer.Attach(data);
            context.Entry(data).State = EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(Trainer data)
        {
            context.Trainer.Attach(data);
            context.Entry(data).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
