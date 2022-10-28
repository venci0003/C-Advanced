using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Date_Modifier
{
    public class DateModifier
    {
        public string CalculateDifferenceBetweenTwoData(string firtData, string secondData)
        {
            string[] firstDataArray = firtData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondDataArray = secondData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            DateTime firstDate = new DateTime(int.Parse(firstDataArray[0]), int.Parse(firstDataArray[1]), int.Parse(firstDataArray[2]));
            DateTime secondDate = new DateTime(int.Parse(secondDataArray[0]), int.Parse(secondDataArray[1]), int.Parse(secondDataArray[2]));

            TimeSpan diff = secondDate.Subtract(firstDate);
            TimeSpan diff1 = secondDate - firstDate;

            string diff2 = (secondDate - firstDate).TotalDays.ToString();
            return diff2;
        }
    }
}
