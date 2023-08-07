using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

        public void CreateTrainer(Trainer createdTrainer)
        {
            int lastTrainerId = db.Trainers[db.Trainers.Count - 1].Id;
            createdTrainer.Id = lastTrainerId + 1;

            db.Trainers.Add(createdTrainer);
        }
    }
}
