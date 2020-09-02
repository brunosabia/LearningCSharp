using System;
using System.Collections.Generic;
using System.Text;

namespace _59_ExSet.Entities
{
    class User
    {
        public int UserCode { get; set; }

        public User(int userCode)
        {
            UserCode = userCode;
        }

        public override int GetHashCode()
        {
            return UserCode.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User))
            {
                return false;
            }

            User other = obj as User;
            return UserCode.Equals(other.UserCode);
            
        }

    }
}
