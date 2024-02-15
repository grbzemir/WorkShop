using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.DataAccess.Abstract;
using WorkShop1.Entities.Concrete;


namespace KodlamaIoDemoHw.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    public List<Instructor> instructors;
    public InstructorDal()
    {
        instructors = new List<Instructor>() {
            new Instructor { FirstName = "Engin", LastName = "Demiroğ", NationalIdentity = "12345678901" , Id=1},
            new Instructor { FirstName = "Ali", LastName = "Kaygusuz", NationalIdentity = "12345678911", Id=2}
        };

    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Delete(int id)
    {
        foreach (var c in instructors)
        {
            if (c.Id == id)
            {
                instructors.Remove(c);
            }
        };
    }

    public List<Instructor> GetAll()
    {
        return instructors.ToList();
    }

    public Instructor GetById(int id)
    {
        foreach (var c in instructors)
        {
            if (c.Id == id)
            {
                return c;

            }
        }
        throw new Exception("Girdiğiniz Id ile eşleşen bir Eğitmen bulunmamaktadır.");
    }

    public void PrintAll(List<Instructor> instructors)
    {
        foreach (var c in instructors)
        {
            PrintInstructor(c);

        }
    }

    public void PrintInstructor(Instructor c)
    {
        Console.WriteLine("Eğitmen ID'si: " + c.Id);
        Console.WriteLine("Eğitmen İsmi: " + c.FirstName);
        Console.WriteLine("Eğitmen Soyismi" + c.LastName);
        Console.WriteLine("");
    }

    public void Update(Instructor i)
    {
        var willUpdateInstructor = GetById(i.Id);
        willUpdateInstructor.FirstName = i.FirstName;
        willUpdateInstructor.LastName = i.LastName;
        willUpdateInstructor.NationalIdentity = i.NationalIdentity;

    }
}
