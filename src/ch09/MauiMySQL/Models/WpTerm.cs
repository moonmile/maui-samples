using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_terms")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpTerm
    {
        [Key]
        [Column("term_id", TypeName = "bigint(20) unsigned")]
        public ulong TermId { get; set; }
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; } = null!;
        [Column("slug")]
        [StringLength(200)]
        public string Slug { get; set; } = null!;
        [Column("term_group", TypeName = "bigint(10)")]
        public long TermGroup { get; set; }
    }
}
