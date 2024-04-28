using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class NumberModel
    {
        //[Range(10,100,ErrorMessage ="please enter range between numbers")]
        public int firstNo { get; set; }
        public int secondNo { get; set; }   
        public int Result { get; set; }
    }
    public class DecimalNumberModel
    {
        //[Range(10,100,ErrorMessage ="please enter range between numbers")]
        public decimal firstNo { get; set; }
        public decimal secondNo { get; set; }
        public decimal Result { get; set; }
    }

}
