using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_users")]
    [Index(nameof(UserEmail), Name = "user_email")]
    [Index(nameof(UserLogin), Name = "user_login_key")]
    [Index(nameof(UserNicename), Name = "user_nicename")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpUser
    {
        [Key]
        [Column("ID", TypeName = "bigint(20) unsigned")]
        public ulong Id { get; set; }
        [Column("user_login")]
        [StringLength(60)]
        public string UserLogin { get; set; } = null!;
        [Column("user_pass")]
        [StringLength(255)]
        public string UserPass { get; set; } = null!;
        [Column("user_nicename")]
        [StringLength(50)]
        public string UserNicename { get; set; } = null!;
        [Column("user_email")]
        [StringLength(100)]
        public string UserEmail { get; set; } = null!;
        [Column("user_url")]
        [StringLength(100)]
        public string UserUrl { get; set; } = null!;
        [Column("user_registered", TypeName = "datetime")]
        public DateTime UserRegistered { get; set; }
        [Column("user_activation_key")]
        [StringLength(255)]
        public string UserActivationKey { get; set; } = null!;
        [Column("user_status", TypeName = "int(11)")]
        public int UserStatus { get; set; }
        [Column("display_name")]
        [StringLength(250)]
        public string DisplayName { get; set; } = null!;
    }
}
