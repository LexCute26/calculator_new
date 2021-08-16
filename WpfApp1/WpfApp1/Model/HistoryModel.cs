using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp1.Model
{
    public class HistoryModel
    {
        public int HistoryID { get; set; }
        public string HistoryAction { get; set; }
        public string HistoryValue { get; set; }
    }
}
