using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_term_relationships")]
    [Index(nameof(TermTaxonomyId), Name = "term_taxonomy_id")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpTermRelationship
    {
        [Key]
        [Column("object_id", TypeName = "bigint(20) unsigned")]
        public ulong ObjectId { get; set; }
        [Key]
        [Column("term_taxonomy_id", TypeName = "bigint(20) unsigned")]
        public ulong TermTaxonomyId { get; set; }
        [Column("term_order", TypeName = "int(11)")]
        public int TermOrder { get; set; }
    }
}
