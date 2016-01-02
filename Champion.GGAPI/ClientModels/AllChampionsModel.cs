using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champion.GGAPI.ClientModels
{
    public class AllChampionsModel
    {
        public string Key { get; set; }
        public long LastUpdated { get; set; }
        public string Name { get; set; }
        public List<RoleModel> Roles { get; set; } 
    }
}
