using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasBlazor.Models
{
    public class GymnastRow
    {
        public int RowNumber { get; set; }

        public IList<Gymnast> Gymnasts { get; set; } = new List<Gymnast>();
    }
}
