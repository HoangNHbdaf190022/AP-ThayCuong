using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Student_Management_System
{
    class Lecturer : Person
    {
        int id;
        string department;

        public Lecturer(int id, string name, DateTime dob, string email, string address, string department)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.email = email;
            this.address = address;
            this.department = department;
        }
        public string DisplayLecturer()
        {
            return ("Lecturer id: " + id +
                "\nLecturer name: " + name +
                "\nDob: " + dob.ToString("dd/MM/yyyy") +
                "\nEmail: " + email +
                "\nAddress: " + address +
                "\nDepartment: " + department);
        }
    }
}
