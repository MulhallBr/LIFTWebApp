using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIFTWebApp.Models;

namespace LIFTWebApp.Controllers
{
    public class LiftController : Controller
    {
        private ILiftRepository repository;
        public LiftController(ILiftRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Lifts);
    }
}