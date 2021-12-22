using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Data
    {
        //Pola klasy
        DateTime data;

        public Data(DateTime data)
        {
            this.data = data;
        }

        public void show()
        {
            Console.WriteLine("Data: "  + data);
        }

        public void nextWeek()
        {
            data = data.AddDays(7);
        }

        public void previousWeek()
        {
            data = data.AddDays(-7);
        }

        public int getYear()
        {
            int year = data.Year;
            return year;
        }        
        public int getMonth()
        {
            int month = data.Month;
            return month;
        }        
        public int getDay()
        {
            int day = data.Day;
            return day;
        }
    }
}
