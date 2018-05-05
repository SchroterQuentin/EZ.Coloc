using System;
using System.Collections.Generic;
using System.Linq;
using EZ.Coloc.Context;
using EZ.Coloc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EZ.Coloc.Controllers
{
    [Route("/api/[controller]")]
    public class SimpleOperationsController : Controller
    {
        Repository _repo;
        public SimpleOperationsController(Repository repo)
        {
            _repo = repo;

        }
        [HttpGet]
        public IEnumerable<SimpleOperation> GetAll()
        {
            return _repo.SimpleOperations.ToList();
        }
    }
}