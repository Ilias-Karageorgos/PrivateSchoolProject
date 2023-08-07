﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolProject.Views.Trainers
{
    internal class ViewTrainer
    {
        public static void GetTrainers(List<Trainer> trainers, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"{"Id",-8}{"Firstname",-15}{"Lastname",-15}");
            Console.ResetColor();

            foreach (var trainer in trainers)
            {
                trainer.PrintTrainer();
            }
        }
        public static void FilteredTrainersByFirstOrLastName(List<Trainer> trainers, string message)
        {
            Console.WriteLine("Give the Firstname");
            string criteriaFirstname = Console.ReadLine().ToLower();

            Console.WriteLine("Give the Lastname");
            string criteriaLastname = Console.ReadLine().ToLower();

            var filteredTrainers = trainers.Where(x => x.LastName.ToLower().Contains(criteriaFirstname)).ToList();
            filteredTrainers = trainers.Where(x => x.LastName.ToLower().Contains(criteriaLastname)).ToList();

            if (filteredTrainers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no Trainer containing {criteriaFirstname} - {criteriaLastname} ");
                Console.ResetColor();
            }
            else
            {
                ViewTrainer.GetTrainers(filteredTrainers, message);
            }
        }
        public static void TrainersCount(List<Trainer> trainers, string message)
        {
            View.PrintColoredMessage(message);
            Console.WriteLine($"Trainers Count is: {trainers.Count}");
            Console.ResetColor();
        }
    }
}
