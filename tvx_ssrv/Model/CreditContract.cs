using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CreditContract
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public float TotalAmt { get; set; }
        [Required]
        [Range(1, 36)]
        public byte MonthQty { get; set; }
        public float Charges => TotalAmt / MonthQty;
    }
}