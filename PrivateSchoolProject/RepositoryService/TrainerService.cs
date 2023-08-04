using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.RepositoryService
{
    internal class TrainerService
    {
        private MyDataBase db = new MyDataBase();

        public List<Trainer> GetTrainers() 
        { 
            return db.Trainers; 
        }
    }
}
