using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentStudent.Models
{
    public interface IRepo

    {
        List<Student> getAll();

        Student create(Student obj);
        Student get(int id);
        void delete(int id);
    }
}
