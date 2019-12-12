using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIFTWebApp.Models
{
    public class EFLiftRepository : ILiftRepository
    {
        private ApplicationDbContext context;

        public EFLiftRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Lift> Lifts => context.Lifts;

        public IQueryable<Exercise> Exercises => context.Exercises;
    }
}
