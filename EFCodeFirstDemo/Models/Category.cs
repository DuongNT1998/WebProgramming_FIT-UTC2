namespace EFCodeFirstDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        public DateTime create_date { get; set; } 

        public DateTime update_date { get; set; }
        public Category()
        {
            create_date = DateTime.Now;
            update_date = create_date;
        }
    }
}
