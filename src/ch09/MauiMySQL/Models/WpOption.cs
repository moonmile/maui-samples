using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_options")]
    [Index(nameof(Autoload), Name = "autoload")]
    [Index(nameof(OptionName), Name = "option_name", IsUnique = true)]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpOption
    {
        [Key]
        [Column("option_id", TypeName = "bigint(20) unsigned")]
        public ulong OptionId { get; set; }
        [Column("option_name")]
        [StringLength(191)]
        public string OptionName { get; set; } = null!;
        [Column("option_value")]
        public string OptionValue { get; set; } = null!;
        [Column("autoload")]
        [StringLength(20)]
        public string Autoload { get; set; } = null!;
    }
}
