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

        public void retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
