using System;
using System.Collections.Generic;
using System.Linq;

namespace LIFTWebApp.Models
{
    public class FakeLiftRepository : ILiftRepository
    {

        public IQueryable<Lift> Lifts => new List<Lift>
        {
            new Lift { DateTimePerformed = "2019-11-15T13:45:30", ExercisePerfromed = "Bench Press", Weight = 150, Reps = 5 },
            new Lift { DateTimePerformed = "2019-11-15T13:50:00", ExercisePerfromed = "Bench Press", Weight = 150, Reps = 7 },
            new Lift { DateTimePerformed = "2019-11-15T13:52:00", ExercisePerfromed = "Bench Press", Weight = 150, Reps = 4 }

        }.AsQueryable<Lift>();

    }
}
