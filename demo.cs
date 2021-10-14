using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Student_Management_System
{
    class demo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            Console.InputEncoding = UnicodeEncoding.UTF8;

            List<Student> std = new List<Student>();
            List<Lecturer> lec = new List<Lecturer>();


            while (true)
            {
                try
                {
                    //Origin Menu
                    Console.WriteLine("*** STUDENT MANAGEMENT SYSTEM ***\n");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1.   Manage Students");
                    Console.WriteLine("2.   Manage Lecturers");
                    Console.WriteLine("3.   Exit");
                    Console.WriteLine("=================================");
                    Console.Write("Please choose: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {   
                        // case 1
                        case 1:
                        // Sub Menu - Student
                        while (true)
                        {
                            try
                            {
                                    Console.WriteLine();
                             Console.WriteLine("\t*** STUDENT MANAGEMENT SYSTEM ***");
                             Console.WriteLine("\tPlease choose from the functions below");
                             Console.WriteLine("======================================================" +
                                "\n\t 1.  Add new student" +
                                "\n\t 2.  View all students" +
                                "\n\t 3.  Update student" +
                                "\n\t 4.  Delete students" +
                                "\n\t 5.  Search students" +
                                "\n\t 6.  Back to main menu" +
                                "\n======================================================"
                                );

                                    Console.Write("Please choose: ");
                                    int chon = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    // add new
                                    if (chon == 1)
                                    {
                                        Console.WriteLine("Create a new student");
                                        Console.WriteLine("=====================");
                                        Console.Write("Student id: ");
                                        string id = Console.ReadLine();
                                        Console.Write("Student name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Date of birth: ");
                                        DateTime dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Address: ");
                                        string add = Console.ReadLine();
                                        Console.Write("Mail: ");
                                        string mail = Console.ReadLine();
                                        Console.Write("Batch: ");
                                        string batch = Console.ReadLine();

                                        std.Add(new Student(id, name, dob, add, mail, batch));
                                        Console.WriteLine("\nSuccessfully created!");
                                    }
                                    //view
                                    else if (chon == 2)
                                    {
                                        Console.WriteLine("===* List all of student *===\n");
                                        foreach (Student stu in std)
                                        {
                                            Console.WriteLine(stu.DisplayStudent());
                                            Console.WriteLine("----------------------------");
                                        }
                                    }
                                    else if (chon == 3)
                                    {
                                        Console.WriteLine("Update student profile");
                                        Console.WriteLine("=========================\n");
                                        Console.Write("ID: ");
                                        string UpdateById = Console.ReadLine();
                                        var updateStudent = std.Find(x => x.id.Equals(UpdateById));
                                        if (updateStudent == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("update a new student");
                                            Console.WriteLine("=====================\n");

                                            Console.Write("Name update: ");
                                            updateStudent.name = Console.ReadLine();
                                            Console.Write("Dob update: ");
                                            updateStudent.dob = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Address update: ");
                                            updateStudent.address = Console.ReadLine();
                                            Console.Write("Mail update: ");
                                            updateStudent.email = Console.ReadLine();
                                            Console.Write("Batch update: ");
                                            updateStudent.batch = Console.ReadLine();

                                            Console.WriteLine("\nSuccessfully updated!");
                                        }
                                    }
                                    else if (chon == 4)
                                    {
                                        Console.WriteLine("Remove a student");
                                        Console.WriteLine("====================\n");
                                        Console.Write("ID: ");
                                        string DeleteById = Console.ReadLine();
                                        var deleteStudent = std.Find(x => x.id.Equals(DeleteById));
                                        if (deleteStudent == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            std.Remove(deleteStudent);
                                            Console.WriteLine("Successfully removed!");
                                        }

                                    }
                                    else if (chon == 5)
                                    {
                                        Console.WriteLine("Searching for students");
                                        Console.WriteLine("=======================\n");
                                        Console.Write("Enter name or id: ");
                                        string SearchByNameOrId = Console.ReadLine();
                                        var SearchStudent = std.Where(x => x.name.Contains(SearchByNameOrId) || x.id.Equals(SearchByNameOrId));

                                        Console.WriteLine("Search results: \n");
                                        foreach (Student student in SearchStudent)
                                        {
                                            Console.WriteLine(student.DisplayStudent());
                                            Console.WriteLine("----------------------------");
                                        }
                                    }
                                    else if (chon == 6)
                                    { break; }
                                }
                                catch 
                                { Console.WriteLine("Thông báo: Vui lòng kiểm tra dữ liệu nhập vào!" +
                                    "\nCó thể bạn nhập vào kí tự thay vì số" +
                                    " hoặc có thể bạn nhập ngày sinh không đúng yêu cầu");  
                                }
                            }
                            //Console.Clear();
                            break;
                        // case 2
                        case 2:
                            Console.WriteLine("\t*** LECTURER MANAGEMENT SYSTEM ***");
                            Console.WriteLine("\tPlease choose from the functions below");
                            Console.WriteLine("======================================================" +
                                "\n\t 1.  Add new lecturer" +
                                "\n\t 2.  View all lecturers" +
                                "\n\t 3.  Update lecturer" +
                                "\n\t 4.  Delete students" +
                                "\n\t 5.  Search lecturers" +
                                "\n\t 6.  Back to main menu" +
                                "\n======================================================"
                                );
                            
                            // Sub Menu - Lecturer
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Please choose: ");
                                    int chonn = int.Parse(Console.ReadLine());
                                    if (chonn == 1)
                                    { Console.WriteLine("Thêm được rồi nhá"); }
                                    else if (chonn == 2)
                                    { Console.WriteLine("Xem được rồi nhá"); }
                                    else if (chonn == 3)
                                    { Console.WriteLine("Sửa được rồi nhá"); }
                                    else if (chonn == 4)
                                    { Console.WriteLine("Xóa được rồi nhá"); }
                                    else if (chonn == 5)
                                    { Console.WriteLine("Search được rồi nhá"); }
                                    else if (chonn == 6)
                                    { break; }
                                }
                                catch
                                {
                                    Console.WriteLine("Thông báo: Vui lòng kiểm tra dữ liệu nhập vào!" +
                                    "\nCó thể bạn nhập vào kí tự thay vì số" +
                                    " hoặc có thể bạn nhập ngày sinh không đúng yêu cầu");
                                }
                            }
                            Console.Clear();
                            break;
                        // case 3: Out
                        case 3: Environment.Exit(0); break;
                        default: Console.WriteLine("Thông báo: Sai phím, mời nhập lại!\n"); break;
                    }
                }catch
                {
                    Program pr = new Program();
                       pr.check();
                }
                //catch { Console.WriteLine("Phải là số! Gõ 0 để tiếp tục");
                //    int tt = int.Parse(Console.ReadLine());
                //    if(tt == 0) { Console.Clear(); }
                //}
            }
        }
    }
}
    