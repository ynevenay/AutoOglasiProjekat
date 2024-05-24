using AutoOglasi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoOglasi.Controllers
{   
    //provera da su korisnici autentifikovani tj ulogovani pre pristupa
    [Authorize]
    public class CarController : Controller
    {
        private readonly IMongoCollection<Car> _car;//kolekcija Cars iz baze
        private readonly UserManager<ApplicationUser> _userManager;

        public CarController(IMongoDatabase database, UserManager<ApplicationUser> userManager)
        {
            _car = database.GetCollection<Car>("Cars");//inicijalizacija kolekcije
            _userManager = userManager;
        }

        //pregledaj sve oglase
        public async Task<IActionResult> Index(string brand,string year)
        {
            //filtriraj po godini proizvodnje
            var filterBuilder = Builders<Car>.Filter;
            var filter = filterBuilder.Empty;

            if (!string.IsNullOrEmpty(brand))
            {
                filter = filterBuilder.And(filter, filterBuilder.Eq(c => c.Brand, brand));

            }
            if (!string.IsNullOrEmpty(year))
            {
                if (int.TryParse(year, out int yearValue))
                {
                    filter = filterBuilder.And(filter, filterBuilder.Eq(c => c.Year, yearValue));
                }
                else
                {
                    Console.WriteLine("Greska");
                }
            }



            var oglasi = await _car.Find(filter).ToListAsync();
            return View(oglasi);
        }
    }
}
