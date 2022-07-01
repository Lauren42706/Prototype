using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Model
{
    /// <summary>
    /// We will refer to databases here I believe. For now it
    /// just has dummy data.
    /// Edit: This is basically where we inherit the class data.
    /// </summary>
    public class ChildProgress
    {
        public int ID { get; set; }
        public string ChildName { get; set; }
        public double ProgressBar { get; set; }
        public string Icon { get; set; }
    }
}
