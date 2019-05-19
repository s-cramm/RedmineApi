using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RedmineApi
{
    public class Project
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public Collection<CustomField> CustomFields { get; set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn { get; private set; }

        internal Project(JToken project)
        {
            Id = (int)project["id"];
            Name = (string)project["name"];
            Identifier = (string)project["identifier"];
            Description = (string)project["description"];
            Status = (int)project["status"];
            CreatedOn = (DateTime)project["created_on"];
            ModifiedOn = (DateTime)project["modified_on"];

            foreach (JToken cF in project["custom_fields"])
            {
                CustomFields.Add(new CustomField(cF));
            }
        }
    }
}
