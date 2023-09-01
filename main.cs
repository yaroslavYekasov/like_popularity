using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace like_popularity
{
    public class mian
    {
        public static void Main()
        {
            List<double> messages = new List<double>();

            Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
            m1.AddLike();
            m1.ShowInfo(m1.Content, m1.Time, m1.GetPopularity(), messages);
            
            Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
            m2.AddLike();
            m2.ShowInfo(m2.Content, m2.Time, m2.GetPopularity(), messages);

            int i = 0;
            int du = 0;
            int da = 1;
            bool pop;
            while (i < messages.Count) 
            {
                pop = messages[du] > messages[da];
                i++;
                du++;
                da++;   
            }

            string popular = "";
            if (pop == true)
            {
                popular = "YOU ARE POPULAR";
            }
            else
            { popular = "you are not popular at all((("; }


            //bool pop = m1.GetPopularity() < m2.GetPopularity();
            //string popular = "";
            //if (pop == true)
            //{
            //    popular = "YOU ARE POPULAR";
            //}
            //else
            //{ popular = "you are not popular at all((("; }
            //Console.WriteLine(popular);
        }
    }
}
