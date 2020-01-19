using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentStudent.Models
{
    public class Repo : IRepo
    {
        List<Student> studentsList = new List<Student>();
        int i = 1;

        public Repo()
        {
            
            studentsList.Add(new Student { id = 1, name = "nishat", department = "SWE" });

        }

        public Student create(Student obj)
        {

            obj.id = i++;
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

        public void update(int id)
        {
            throw new NotImplementedException();
        }



    }
}
