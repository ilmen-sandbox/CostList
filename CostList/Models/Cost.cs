namespace CostList.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Cost
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }

        [DisplayName("Описание")]
        [Required]
        public string Description { get; set; }

        [DisplayName("Стоимость")]
        [Required]
        public float Amount { get; set; }
    }
}