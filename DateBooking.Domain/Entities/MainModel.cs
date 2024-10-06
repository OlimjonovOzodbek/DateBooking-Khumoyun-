using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBooking.Domain.Entities
{
    public class MainModel
    {
        public long Id { get; set; }
        public string Date {  get; set; }
        public string Time {  get; set; }
    }
}
