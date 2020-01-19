using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentStudent.Models
{
    interface IRepo

    {
        List<Student> getAll();

        void create(Student obj);
        void update(int id);
        void retrieve(int id);
        void delete(int id);
    }
}
