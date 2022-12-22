using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_termmeta")]
    [Index(nameof(TermId), Name = "term_id")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpTermmetum
    {
        [Key]
        [Column("meta_id", TypeName = "bigint(20) unsigned")]
        public ulong MetaId { get; set; }
        [Column("term_id", TypeName = "bigint(20) unsigned")]
        public ulong TermId { get; set; }
        [Column("meta_key")]
        [StringLength(255)]
        public string? MetaKey { get; set; }
        [Column("meta_value")]
        public string? MetaValue { get; set; }
    }
}
