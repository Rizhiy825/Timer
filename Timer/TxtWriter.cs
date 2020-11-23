using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TxtWriter
    {
        public static void Writer(TimeSpan timeSpan)
        {
            var today = new DateTime();
            today = DateTime.Now;
            var todayString = today.ToShortDateString();
            var timeSpanString = timeSpan.ToString("hh':'mm':'ss");
            var write = new StreamWriter(@"C:\Users\User\Source\Repos\Rizhiy825\Timer\Timer\Logs.txt", true);
            write.Write(todayString + " ");
            write.WriteLine(timeSpanString);
            write.Close();
        }

        public static DateTime Reader(DateTime selectedDate)
        {
            var write = new StreamReader(@"C:\Users\User\Source\Repos\Rizhiy825\Timer\Timer\Logs.txt");
            string line;
            var resultTime = new DateTime();

            while ((line = write.ReadLine()) != null)
            {
                var parsedDate = DateTime.Parse(line);

                if (selectedDate.Day == parsedDate.Day &&
                    selectedDate.Month == parsedDate.Month &&
                    selectedDate.Year == parsedDate.Year)
                {
                    resultTime = resultTime.AddSeconds(parsedDate.Second);
                    resultTime = resultTime.AddMinutes(parsedDate.Minute);
                    resultTime = resultTime.AddHours(parsedDate.Hour);
                }
            }
            write.Close();
            return resultTime;
        }

        public static List<DateTime> Checker()
        {
            var write = new StreamReader(@"C:\Users\User\Source\Repos\Rizhiy825\Timer\Timer\Logs.txt");
            string line;
            List<DateTime> dates = new List<DateTime>();
            DateTime parsetDate = new DateTime();
            while ((line = write.ReadLine()) != null)
            {
                var lineDate = DateTime.Parse(line);

                if (parsetDate.Year != lineDate.Year ||
                    parsetDate.Month != lineDate.Month ||
                    parsetDate.Day != lineDate.Day)
                {
                    parsetDate = DateTime.Parse(line);
                    dates.Add(parsetDate);
                }
            }
            write.Close();
            return dates;
        }
    }
}
