using System;
using System.Collections.Generic;
using System.Text;

namespace RedmineApi
{
    public class Activity
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Activity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
