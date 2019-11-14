using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIFTWebApp.Models
{
    public class Lift
    {
        public int LiftID { get; set; }
        public int UserID { get; set; }
        public string DateTimePerformed { get; set; }
        public string ExercisePerfromed { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
    }
}
