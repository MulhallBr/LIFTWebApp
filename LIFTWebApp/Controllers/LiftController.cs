using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LIFTWebApp.Models;
using LIFTWebApp.Models.ViewModels;

namespace LIFTWebApp.Controllers
{
    public class LiftController : Controller
    {
        private ILiftRepository repository;
        public int PageSize = 8;

        public LiftController(ILiftRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1)
            => View(new LiftsListViewModel
            {
                Lifts = repository.Lifts
                    .OrderBy(p => p.LiftID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Lifts.Count()
                }
            });
    }
}