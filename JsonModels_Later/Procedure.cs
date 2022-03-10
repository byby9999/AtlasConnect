using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasConnect.JsonModels_Later
{
    public class ProcedureEntity
    {
        public ObjectId? _id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public bool? SpecificBodySideRequired { get; set; }
        public string TenantId { get; set; }
    }
}
