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
            monday,
            tuseday, 
            wednesday, 
            thursday,
            friday,
            saturday, 
            sunday
        }

        
    }
}
