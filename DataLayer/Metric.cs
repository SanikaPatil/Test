using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Metric
    {
        [Key]
        public int sr_no { get; }
        public decimal Temperature { get; set; }
        public decimal Weight { get; set; }
        public decimal Distance { get; set; }
    }
}