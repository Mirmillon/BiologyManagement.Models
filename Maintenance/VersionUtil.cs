using System;
using System.Collections.Generic;
using System.Text;

namespace BiologyManagement.Models.LoincFrance
{
    public class VersionUtil
    {
   

        public VersionUtil()
        {
            Liste = new List<string>();
        }

        public string  VersionId { get; set; }

        public string Label { get; set; }

        public void SetLabel(string s )
        {
            Liste.Add(s);
        }
        public List<String> Liste { get; set; }

       
    }
}
