using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class studentModel
    {
        [Range(1,100)]
        public int RollNo { get; set; }
        [StringLength(maximumLength:50,MinimumLength=10)]
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public string Address { get; set; }
         public string Faculty { get; set; }
    }
}
