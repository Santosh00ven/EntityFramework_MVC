using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.Repository
{
    public interface ITrainerRepo
    {
        void Add(Trainer data);
        void Update(Trainer data);
        List<Trainer> GetList();
        Trainer GetById(int id);
        void Delete(Trainer data);

    }
}
