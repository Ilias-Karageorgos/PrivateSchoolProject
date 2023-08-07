using PrivateSchoolProject.RepositoryService;
using PrivateSchoolProject.Views.Courses;
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
        TrainerService trainerService = new TrainerService();

        public void GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                trainers = trainerService.GetTrainers();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewTrainer.GetTrainers(trainers, $"{"",15}All Trainers\n");
        }
        public void GetFilteredTrainersByFirstOrLastName()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                trainers = trainerService.GetTrainers();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewTrainer.FilteredTrainersByFirstOrLastName(trainers, $"{"",5}Filtered Trainers by Firstname or Lastname\n");
        }
        public void GetTrainersCount()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                trainers = trainerService.GetTrainers();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            ViewTrainer.TrainersCount(trainers, $"{"",25}Trainers Count\n");
        }



        public void TrainersOrderedBy(string prop)
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                trainers = trainerService.GetTrainers();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            switch (prop)
            {
                case "LastName": ViewTrainer.GetTrainers(trainers.OrderBy(x => x.LastName).ToList(), $"{"",25}Trainers Ordered by Lastname\n"); break;
                case "FirstName": ViewTrainer.GetTrainers(trainers.OrderBy(x => x.FirstName).ToList(), $"{"",25}Trainers Ordered by Firstname\n"); break;
            }
        }
    }
}
