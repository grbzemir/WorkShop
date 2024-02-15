using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Business.Concrete;
using WorkShop1.DataAccess.Concrete;
using WorkShop1.Entities.Concrete;
using WorkShop1.Business.Abstract;
using WorkShop1.DataAccess.Abstract;
using KodlamaIoDemoHw.DataAccess.Concretes;


CourseManager courseManager = new CourseManager(new CourseDal());

Console.WriteLine("********************Get All********************");
List<Course> courses = courseManager.GetAll();
courseManager.PrintAll(courses);
Console.WriteLine(" ");
Console.WriteLine(" ");


Console.WriteLine("********************Add Course********************");
courseManager.Add(new Course()
{
    CourseName = "Python,",
    CourseId = 3,
    CourseDescription = "Python İleri Seviye Programla Eğitimi",
    InstructorId = 1,
    CategoryId = 3,
    ImagePath = "python.png",
    CourseProces = 23
});
courseManager.PrintAll(courses);
Console.WriteLine(" ");
Console.WriteLine(" ");


Console.WriteLine("********************Update Course********************");
courseManager.Update(new Course()
{
    CourseName = "Python,",
    CourseId = 3,
    CourseDescription = "Python İleri Seviye Programla Eğitimi",
    InstructorId = 1,
    CategoryId = 3,
    ImagePath = "python.png",
    CourseProces = 93
});
courseManager.PrintAll(courses);
Console.WriteLine(" ");
Console.WriteLine(" ");


Console.WriteLine("********************Delete Course********************");
courseManager.Delete(2);
courseManager.PrintAll(courses);
Console.WriteLine(" ");
Console.WriteLine(" ");


Console.WriteLine("********************Get Course By Id********************");
courseManager.PrintCourse(courseManager.GetById(3));
Console.WriteLine(" ");
Console.WriteLine(" ");
