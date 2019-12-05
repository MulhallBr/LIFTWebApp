using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIFTWebApp.Models.ViewModels
{
    public class NewLiftViewModel
    {

        public Lift Lift { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }

    }
}
