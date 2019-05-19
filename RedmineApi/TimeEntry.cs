using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace RedmineApi
{
    public class TimeEntry
    {
        public int Id { get; private set; }
        public Project Project { get; set; }
        public Issue Issue { get; set; }
        public User User { get; set; }
        public Activity Activity { get; set; }

    }
}
