using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TM.DailyTrackR.View
{
    class Test
    {
        public Test(string text, bool check, List<string> combo, string link)
        {
            this.Text = text;
            this.Check = check;
            this.Link = link;
            this.ComboBoxList = combo;
        }
        public string Text { get; set; }
        public bool Check { get; set; }
        public List<string> ComboBoxList { get; set; }
        public string Link { get; set; }
    }
}
