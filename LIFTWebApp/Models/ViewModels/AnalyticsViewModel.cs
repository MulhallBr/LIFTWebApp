using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIFTWebApp.Models.ViewModels
{
    public class AnalyticsViewModel
    {
        public IEnumerable<Lift> Lifts { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
