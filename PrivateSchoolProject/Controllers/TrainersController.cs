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
            ViewTrainer.Trainers(db.Trainers, $"{"",15}All Trainers\n");
        }
        public void GetFilteredTrainersByFirstOrLastName()
        {
            ViewTrainer.FilteredTrainersByFirstOrLastName(db.Trainers, $"{"",5}Filtered Trainers by Firstname or Lastname\n");
        }
        public void GetTrainersCount()
        {
            ViewTrainer.TrainersCount(db.Trainers, $"{"",25}Trainers Count\n");
        }
    }
}
