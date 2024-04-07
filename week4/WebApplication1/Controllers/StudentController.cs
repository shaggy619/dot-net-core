using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentDetail()
        {
            studentModel student = new studentModel();
            student.RollNo = 10;
            student.FirstName= "Aayushma";
            student.LastNAme = "kc";
            student.Address ="Bhaktapur";
            student.Faculty = "CSIT";

            return View(student);
        }
        //[Route("All-Students")]
        public IActionResult StudentsDetail()
        {
            
            List<studentModel>students= new List<studentModel>();
            studentModel student1 = new studentModel();
            student1.RollNo = 10;
            student1.FirstName = "Aayushma";
            student1.LastNAme = "kc";
            student1.Address = "Bhaktapur";
            student1.Faculty = "CSIT";

            studentModel student2 = new studentModel();
            student2.RollNo = 10;
            student2.FirstName = "puja";
            student2.LastNAme = "kc";
            student2.Address = "Bhaktapur";
            student2.Faculty = "CSIT";

            studentModel student3 = new studentModel();
            student3.RollNo = 10;
            student3.FirstName = "rujita";
            student3.LastNAme = "kc";
            student3.Address = "Bhaktapur";
            student3.Faculty = "CSIT";

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            ArrayList arraylist = new ArrayList();
            arraylist.Add(student1);
            arraylist.Add(5);
            arraylist.Add("Hello");

            return View(students);

            
        }
    }
}
