using System;
using System.Collections.Generic;
using System.Linq;
using EZ.Coloc.Context;
using EZ.Coloc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EZ.Coloc.Controllers
{
    [Route("/api/[controller]")]
    public class UsersController : Controller
    {
        Repository _repo;
        public UsersController(Repository repo)
        {
            _repo = repo;

        }
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _repo.Users.ToList();
        }
    }
}