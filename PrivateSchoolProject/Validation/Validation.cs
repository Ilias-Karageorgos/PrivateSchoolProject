using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace PrivateSchoolProject.Validation
{
    internal class Validation
    {
        internal static bool CheckInputString(string inputString) 
        {
            return (inputString.Any(x => char.IsDigit(x) || char.IsSymbol(x) || x == '!') || string.IsNullOrWhiteSpace(inputString)) || inputString.Length < 3  ? false : true;
        }
        internal static bool CheckDateOfBirth(DateTime dateOfBirth)
        {
            return dateOfBirth.Year > DateTime.Now.Year - 18 || dateOfBirth == (default);                  
        }
        internal static bool CheckTuitionFees(string inputTuitionFees)
        {
            int tuitionFeesNumber;
            bool result = int.TryParse(inputTuitionFees, out tuitionFeesNumber);

            return tuitionFeesNumber > 10000 || tuitionFeesNumber < 0 || result == false;
        }
        internal static bool CheckStartDate(DateTime startDate)
        {
            return startDate < DateTime.Now || startDate == DateTime.Now;        
        }
        internal static bool CheckEndDate(DateTime startDate, DateTime endDate)
        {
            return endDate > startDate;
        }

        internal static bool CheckType(string type)
        {
            return Regex.IsMatch(type, "^[0-1]$");            
        }

        internal static bool CheckStream(string courseStream)
        {
            return Regex.IsMatch(courseStream, "^(cb|CB)-[8-9]$|^(cb|CB)-1([0-2])$");
        }
      
        internal static bool CheckOralMark(string inputMark)
        {
            int inputMarkNumber;
            bool result = int.TryParse(inputMark, out inputMarkNumber);
            return inputMarkNumber > 100 || inputMarkNumber < 0 || result == false;
        }

        internal static bool CheckTotalMark(string inputTotalMark, int inputOralMark)
        {
            int inputMarkNumber;
            bool result = int.TryParse(inputTotalMark, out inputMarkNumber);
            return inputMarkNumber > 100 || inputMarkNumber < inputOralMark || result == false;
        }
    }
}
