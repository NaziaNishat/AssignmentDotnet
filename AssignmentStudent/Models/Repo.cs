using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentStudent.Models
{
    public class Repo : IRepo
    {
        List<Student> studentsList = new List<Student>();
        int i = 0;

        public Repo()
        {

            studentsList.Add(new Student { id = 1, name = "nishat", department = "SWE" });
            studentsList.Add(new Student { id = 2, name = "mahima", department = "SWE" });
            studentsList.Add(new Student { id = 3, name = "afrin", department = "SWE" });

        }

        public Student create(Student obj)
        {

            obj.id = studentsList.Max(e => e.id) + 1;
           studentsList.Add(obj);
            return obj;
        }

        public void delete(int id)
        {
            studentsList.RemoveAt(id-1);
        }

        public List<Student> getAll()
        {
            return studentsList;
        }

        public Student retrieve(int id)
        {
            return studentsList.FirstOrDefault(e => e.id == id );
        }

        public Student update(int id)
        {
            return studentsList.FirstOrDefault(e => e.id == id);
        }



    }
}
