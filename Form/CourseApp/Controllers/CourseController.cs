using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController:Controller
    {
        //Action metod
        public IActionResult Index(){
            //localhost:5000/course/index => course/index.cshtml
           
            return View();

        }

           public IActionResult Details(){
             //localhost:5000/course/details => course/details.cshtml

           var course = new Course();
           course.Name = "Core MCV COURSE";
           course.description = "Good Course";
           course.isPublished = true;
            return View(course);
            
        }
        #region Form Create
        [HttpGet]
        public IActionResult Apply()
        {
           //localhost:5000/course/apply
           
          return View();
        }
        #endregion

        #region Post

         [HttpPost]
        public IActionResult Apply(People people)
        {

           //localhost:5000/course/apply metod:POST
           //name=value&Email=value&Phone=value&
            //Model Binding
            if(ModelState.IsValid){
                 Repository.Addpeople(people);
                  return View("Thanks", people);
            }else{
                return View(people);
            }
           

         
        }
        #endregion

         public IActionResult List(){
             //localhost:5000/course/list => course/list.cshtml
             var people = Repository.People.Where(i => i.Confirm== true);

            return View(people);
            
        }
    }
}