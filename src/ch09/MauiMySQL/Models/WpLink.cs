using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_links")]
    [Index(nameof(LinkVisible), Name = "link_visible")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpLink
    {
        [Key]
        [Column("link_id", TypeName = "bigint(20) unsigned")]
        public ulong LinkId { get; set; }
        [Column("link_url")]
        [StringLength(255)]
        public string LinkUrl { get; set; } = null!;
        [Column("link_name")]
        [StringLength(255)]
        public string LinkName { get; set; } = null!;
        [Column("link_image")]
        [StringLength(255)]
        public string LinkImage { get; set; } = null!;
        [Column("link_target")]
        [StringLength(25)]
        public string LinkTarget { get; set; } = null!;
        [Column("link_description")]
        [StringLength(255)]
        public string LinkDescription { get; set; } = null!;
        [Column("link_visible")]
        [StringLength(20)]
        public string LinkVisible { get; set; } = null!;
        [Column("link_owner", TypeName = "bigint(20) unsigned")]
        public ulong LinkOwner { get; set; }
        [Column("link_rating", TypeName = "int(11)")]
        public int LinkRating { get; set; }
        [Column("link_updated", TypeName = "datetime")]
        public DateTime LinkUpdated { get; set; }
        [Column("link_rel")]
        [StringLength(255)]
        public string LinkRel { get; set; } = null!;
        [Column("link_notes", TypeName = "mediumtext")]
        public string LinkNotes { get; set; } = null!;
        [Column("link_rss")]
        [StringLength(255)]
        public string LinkRss { get; set; } = null!;
    }
}
