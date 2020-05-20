using BiologyManagement.Models.LoincFrance.EnumTable;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BiologyManagement.Models.LoincFrance
{
    public class ActebiologiqueVersion
    {
        public string ActeBiologiqueId { get; set; }
        public ActeBiologique ActeBiologique { get; set; }

        public int VersionId { get; set; }
        public VersionActe Version { get; set; }
    }
}
