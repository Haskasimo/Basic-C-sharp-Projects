using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
   public class DayOfWeek
    {
        public WeekDays Days { get; set; }

        public enum WeekDays
        {
            Monday,
            Tuseday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday, 
            Sunday
        }

        
    }
}
