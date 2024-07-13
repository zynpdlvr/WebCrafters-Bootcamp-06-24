using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers{

    public class BootcampController : Controller{
        public IActionResult Index(){
            var bootcamp = new Bootcamp();
            bootcamp.Id = 1;
            bootcamp.Desc = "a desc";
            bootcamp.Title= "atitle";
            return View(bootcamp); //get bootcamp var
        } 
        public IActionResult List(){
            var Bootcamps = new List<Bootcamp>(){
                new Bootcamp() {Id= 0, Title= "Title 1 for bootcamp 1", Desc = "Description for bootcamp 1"},
                new Bootcamp() {Id= 1, Title= "Title 2 for bootcamp 2", Desc = "Description for bootcamp 2"},
                new Bootcamp() {Id= 2, Title= "Title 3 for bootcamp 3", Desc = "Description for bootcamp 3"}
            };
            return View(Bootcamps); // can call views by name as "List"
        } 
    }
}