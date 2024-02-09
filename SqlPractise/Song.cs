using System;
using System.Collections;
using System.Collections.Generic;

namespace SqlPractise
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId {  get; set; }

        public virtual ICollection<Song> Songs { get; set;}

        public virtual Group Group { get; set; }
    }
}
