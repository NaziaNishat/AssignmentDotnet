using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentStudent.Models
{
    public class Repo : IRepo
    {
        List<Student> studentsList;

        public Repo()
        {
            studentsList = new List<Student>();
            studentsList.Add(new Student { id = 1, name = "nishat", department = "SWE" });
            studentsList.Add(new Student { id = 2, name = "nazia", department = "SWE" });

        }

        public void create(Student obj)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
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

        void IRepo.retrieve(int id)
        {
            throw new NotImplementedException();
        }
    }
}
