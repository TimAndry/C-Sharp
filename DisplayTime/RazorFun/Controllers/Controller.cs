 using Microsoft.AspNetCore.Mvc;
    namespace RazorFun     //be sure to use your own project's namespace!
    {
        public class List : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View("Index");
            }
        }
    }