 using Microsoft.AspNetCore.Mvc;
 namespace RazorFun //be sure to use your own project's namespace!
 {
     public class List : Controller //remember inheritance??
     {
         //for each route this controller is to handle:
         [HttpGet] //type of request
         [Route ("")] //associated route string (exclude the leading /)
         public IActionResult Index () {
             return View ("Index");
         }

         [HttpPost ("results")]
         public IActionResult results (Survey dojostudent) {
             if (ModelState.IsValid) {
                 Survey student = new Survey () {
                     Name = dojostudent.Name,
                     Language = dojostudent.Language,
                     Location = dojostudent.Location,
                     Comment = dojostudent.Comment,
                 };
                 return View ("results", student);
             }else{
                 System.Console.WriteLine("we have errors");
                 return View("index");
             }
         }
     }
 }