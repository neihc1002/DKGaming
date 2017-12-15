namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(255)]
        public string MetaTitle { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        public decimal? Price { get; set; }

        public decimal? WholesalePrices { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Quantity { get; set; }

        public int? CateId { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "xml")]
        public string Color { get; set; }

        public int? SellNumber { get; set; }

        public bool? Status { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }
    }
}
