using System;
using System.Collections.Generic;
using System.Text;

namespace AtlasConnect.JsonModels
{
    public class BaseJson
    {
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedOn { get; set; }
    }
}
