using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_commentmeta")]
    [Index(nameof(CommentId), Name = "comment_id")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpCommentmetum
    {
        [Key]
        [Column("meta_id", TypeName = "bigint(20) unsigned")]
        public ulong MetaId { get; set; }
        [Column("comment_id", TypeName = "bigint(20) unsigned")]
        public ulong CommentId { get; set; }
        [Column("meta_key")]
        [StringLength(255)]
        public string? MetaKey { get; set; }
        [Column("meta_value")]
        public string? MetaValue { get; set; }
    }
}
