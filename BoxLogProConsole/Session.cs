using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLogProConsole
{
    public class Session
    {
        public DateTime Date { get; set; }
        public int DurationMinutes { get; set; }
        public string Type { get; set; } // e.g., "Sparring", "Bag Work"
        public string Notes { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {DurationMinutes} min - {Type} - {Notes}";
        }
    }
}
