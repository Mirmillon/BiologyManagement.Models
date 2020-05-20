using System;
using System.Collections.Generic;
using System.Text;

namespace BiologyManagement.Models.LoincFrance
{
    public class CodeUTIL
    {
        public CodeUTIL()
        {
            Liste = new List<string>();
        }
        public string CodeUTILId { get; set; }


        public string Label { get; set; }

        public List<String> Liste { get; set; }

        public void SetLabel(string label)
        {
            Liste.Add(label);
        }
    }
}
