using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_usermeta")]
    [Index(nameof(UserId), Name = "user_id")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpUsermetum
    {
        [Key]
        [Column("umeta_id", TypeName = "bigint(20) unsigned")]
        public ulong UmetaId { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
        [Column("meta_key")]
        [StringLength(255)]
        public string? MetaKey { get; set; }
        [Column("meta_value")]
        public string? MetaValue { get; set; }
    }
}
