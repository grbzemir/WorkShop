using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.DataAccess.Abstract;
using WorkShop1.Entities.Concrete;

namespace KodlamaIoDemoHw.DataAccess.Concretes
{
    internal class CourseDal : ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>() {
                new Course { CourseName="C#,",CourseId=1,CourseDescription="C# İleri Seviye Programla Eğitimi",InstructorId=1,CategoryId=2,ImagePath="csharp.png", CourseProces=10},
                 new Course { CourseName="JAVA,",CourseId=2,CourseDescription="JAVA İleri Seviye Programlama Eğitimi",InstructorId=3,ImagePath="java.png",CategoryId=6, CourseProces=38 }
            };

        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            var willDeleteCourse = GetById(id);
            courses.Remove(willDeleteCourse);
        }

        public void Delete(Course Course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            foreach (var c in courses)
            {
                if (c.CourseId == id)
                {
                    return c;

                }
            }
            throw new Exception("Girdiğiniz Id ile eşleşen bir Kurs bulunmamaktadır.");
        }

        public void PrintAll(List<Course> courses)
        {
            foreach (var c in courses)
            {
                PrintCourse(c);

            }
        }
        public void PrintCourse(Course c)
        {
            Console.WriteLine("Kurs Adı: " + c.CourseName);
            Console.WriteLine("Kurs Açıklaması: " + c.CourseDescription);
            Console.WriteLine("Kurs ID'si: " + c.CourseId);
            Console.WriteLine("Kategori ID'si: " + c.CategoryId);
            Console.WriteLine("Eğitmen ID'si: " + c.InstructorId);
            Console.WriteLine("Kurs Resmi Linki: " + c.ImagePath);
            Console.WriteLine("Kurs İlerlemesi: " + c.CourseProces);
            Console.WriteLine("");
        }

        public void Update(Course c)
        {
            var willUpdateCourse = GetById(c.CourseId);
            willUpdateCourse.CourseName = c.CourseName;
            willUpdateCourse.CourseDescription = c.CourseDescription;
            willUpdateCourse.CategoryId = c.CategoryId;
            willUpdateCourse.InstructorId = c.InstructorId;
            willUpdateCourse.ImagePath = c.ImagePath;
            willUpdateCourse.CourseProces = c.CourseProces;
        }
    }
}