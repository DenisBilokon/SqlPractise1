using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlPractise
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }   //? - тип, который принимает nullable
    }
}
