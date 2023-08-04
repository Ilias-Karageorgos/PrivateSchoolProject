using PrivateSchoolProject.Views.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Controllers
{
    internal class TrainersController
    {
        MyDataBase db = new MyDataBase();

        public void GetTrainers()
        {
            var trainers = db.Trainers;
            ViewTrainer.Trainers(trainers, $"{"",15}All Trainers\n");
        }
        public void GetFilteredTrainersByFirstOrLastName()
        {
            var trainers = db.Trainers;
            ViewTrainer.FilteredTrainersByFirstOrLastName(trainers, $"{"",5}Filtered Trainers by Firstname or Lastname\n");
        }
        public void GetTrainersCount()
        {
            var trainers = db.Trainers;
            ViewTrainer.TrainersCount(trainers, $"{"",25}Trainers Count\n");
        }
    }
}
