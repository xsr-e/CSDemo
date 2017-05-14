using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Service Context
            SchoolDataServiceContext.SchoolDBEntities svc
                = new SchoolDataServiceContext.SchoolDBEntities(
                    new Uri("http://localhost:1030/SchoolData.svc/"));


            var queryTeacher = from t in svc.Teachers
                               where t.Class == "4B"
                               select t;

            var firstTeacher = queryTeacher.FirstOrDefault();
            
            //Lazy load Students property
            svc.LoadProperty(firstTeacher, "Students");
            var firstTeacherStudents = from s in firstTeacher.Students
                                       select s;

            firstTeacherStudents
                .ToList()
                .ForEach(
                s =>
                {
                    Console.WriteLine("Id {0} , FullName {2}, {1} ", s.Id, s.FirstName, s.LastName);
                    Console.WriteLine("Teacher FullName {1}, {0}",firstTeacher.FirstName, firstTeacher.LastName);
                }
                );


        }
    }
}
