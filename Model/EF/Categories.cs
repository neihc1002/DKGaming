namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int CatId { get; set; }

        [StringLength(50)]
        public string CatName { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(255)]
        public string MetaTitle { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }

        public bool? Status { get; set; }

        [StringLength(255)]
        public string SeoTitle { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
