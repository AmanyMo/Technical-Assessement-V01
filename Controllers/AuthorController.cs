using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Assessement_V01.Data;
using Technical_Assessement_V01.Models;

namespace Technical_Assessement_V01.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController:ControllerBase
    {
        private readonly App_DBContext _Db;
        public AuthorController(App_DBContext db)
        {
            _Db = db;
        }

        [HttpGet]
        public   IActionResult   GetAuthors()
        {
            return Ok(_Db.Author.ToList());
        }
    }
}
