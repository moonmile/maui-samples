using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_term_taxonomy")]
    [Index(nameof(Taxonomy), Name = "taxonomy")]
    [Index(nameof(TermId), nameof(Taxonomy), Name = "term_id_taxonomy", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpTermTaxonomy
    {
        [Key]
        [Column("term_taxonomy_id", TypeName = "bigint(20) unsigned")]
        public ulong TermTaxonomyId { get; set; }
        [Column("term_id", TypeName = "bigint(20) unsigned")]
        public ulong TermId { get; set; }
        [Column("taxonomy")]
        [StringLength(32)]
        public string Taxonomy { get; set; } = null!;
        [Column("description")]
        public string Description { get; set; } = null!;
        [Column("parent", TypeName = "bigint(20) unsigned")]
        public ulong Parent { get; set; }
        [Column("count", TypeName = "bigint(20)")]
        public long Count { get; set; }
    }
}
