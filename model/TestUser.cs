using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchPerfect.model
{
    class TestUser
    {
        //test cases - NewId()
        //null json file should post an error
        //empty json should assign 1
        //non-empty json should assign count + 1 value
        public static bool TestSound()
        {
            /*User player1 = new User("shawn");
            if (Users.UserList == null && player1 != null)
            {
                return false;
            } else if (Users.GetUserCount() == 0 && player1.Id != 1)
            {
                return false;
            } else if (Users.GetUserCount() > 0)
            {
               int expected = Users.GetUserCount() + 1;
               if (player1.Id != expected)
                {
                    return false;
                }
            }
*/
            Sounds.SoundList[0].PlaySound();
            Console.Read();
            return true;
        }
        
    }
}
