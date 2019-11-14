using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace LIFTWebApp.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Lifts.Any())
            {
                context.Lifts.AddRange(

                    new Lift { 
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T13:45:30", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 5 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T13:50:00", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 7 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T13:52:00", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 4 },

                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T13:59:00",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T14:02:00",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15T14:06:00",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 }

                    );
                context.SaveChanges();
            }
        }
    }
}
