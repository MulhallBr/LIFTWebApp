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


        public static void EnsureDeleted(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureDeleted();
        }


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
                        DateTimePerformed = "2019-11-15", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 5 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 7 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15", 
                        ExercisePerfromed = "Bench Press", 
                        Weight = 150, Reps = 4 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-15",
                        ExercisePerfromed = "Bicep Curls",
                        Weight = 50, Reps = 10 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-18",
                        ExercisePerfromed = "Bench Press",
                        Weight = 155,
                        Reps = 6 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-18",
                        ExercisePerfromed = "Bench Press",
                        Weight = 155,
                        Reps = 7 },
                    new Lift {
                        UserID = 1,
                        DateTimePerformed = "2019-11-18",
                        ExercisePerfromed = "Bench Press",
                        Weight = 155,
                        Reps = 5 }
                    );

                context.SaveChanges();
            }
        }
    }
}
