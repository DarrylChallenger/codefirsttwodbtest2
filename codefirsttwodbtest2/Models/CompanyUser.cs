namespace codefirsttwodbtest2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyUser")]
    public partial class CompanyUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? CompanyId { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }
    }
}
