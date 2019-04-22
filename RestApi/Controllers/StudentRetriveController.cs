using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class StudentRetriveController : ApiController
    {
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().getAllStudent();
        }
        [Route("api/studentregistration")]
        public StudentRegistrationReply registerStudent(Student studentregd)
        {
            Console.WriteLine("In registerStudent");
            StudentRegistrationReply stdregreply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(studentregd);
            stdregreply.Name = studentregd.Name;
            stdregreply.Age = studentregd.Age;
            stdregreply.RegistrationNumber = studentregd.RegistrationNumber;
            stdregreply.RegistrationStatus = "Successful";
            return stdregreply;
        }
    }
}
