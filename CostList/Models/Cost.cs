namespace CostList.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class CostContext: DbContext
    {
        public DbSet<Cost> Costs { get; set; }

        public CostContext() : base("DefaultConnection")
        {

        }
    }

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