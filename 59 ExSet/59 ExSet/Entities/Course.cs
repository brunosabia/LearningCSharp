using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _59_ExSet.Entities
{
    class Course
    {
        
        HashSet<User> Crs = new HashSet<User>();

        public void addUser(int code)
        {
            Crs.Add(new User(code));
        }

        public void printCourse()
        {
            foreach (User item in Crs)
            {
                Console.WriteLine("UserCode: " + item.UserCode);
            }
        }
        
        public int Count()
        {
            return Crs.Count;
        }
        
    }
}
