using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_postmeta")]
    [Index(nameof(PostId), Name = "post_id")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpPostmetum
    {
        [Key]
        [Column("meta_id", TypeName = "bigint(20) unsigned")]
        public ulong MetaId { get; set; }
        [Column("post_id", TypeName = "bigint(20) unsigned")]
        public ulong PostId { get; set; }
        [Column("meta_key")]
        [StringLength(255)]
        public string? MetaKey { get; set; }
        [Column("meta_value")]
        public string? MetaValue { get; set; }
    }
}
