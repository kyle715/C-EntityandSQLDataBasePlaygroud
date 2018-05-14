using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = new TESTEntities();
            var post = new Table_1()
            {
                Body = "body",
                DatPulished = DateTime.Now,
                PostID = 2,
                Title = "Title"

            };
            content.Table_1.Add(post);
            content.SaveChanges();
        }
    }
}
