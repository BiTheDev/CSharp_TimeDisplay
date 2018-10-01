using System;
using Microsoft.AspNetCore.Mvc;
    namespace TimeDisplay.Controllers     //be sure to use your own project's namespace!
    {
        public class TimeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                DateTime CurrentTime = DateTime.Now;
                ViewBag.Time = CurrentTime.ToString("MMMM dd, yyyy  hh:mm tt");
                return View("index");    
            }
        }
    }