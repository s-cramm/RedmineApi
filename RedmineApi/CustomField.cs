using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace RedmineApi
{
    public class CustomField
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Value { get; set; }

        internal CustomField(JToken customField)
        {
            Id = (int)customField["id"];
            Name = (string)customField["Name"];
            Value = (string)customField["value"];
        }
    }
}
