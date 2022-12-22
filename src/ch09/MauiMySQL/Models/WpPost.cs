using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
[Table("wp_posts")]
[Index(nameof(PostAuthor), Name = "post_author")]
[Index(nameof(PostParent), Name = "post_parent")]
[Index(nameof(PostType), nameof(PostStatus), nameof(PostDate), nameof(Id), Name = "type_status_date")]
[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class WpPost
{
    [Key]
    [Column("ID", TypeName = "bigint(20) unsigned")]
    public ulong Id { get; set; }
    [Column("post_author", TypeName = "bigint(20) unsigned")]
    public ulong PostAuthor { get; set; }
    [Column("post_date", TypeName = "datetime")]
    public DateTime PostDate { get; set; }
    [Column("post_date_gmt", TypeName = "datetime")]
    public DateTime PostDateGmt { get; set; }
    [Column("post_content")]
    public string PostContent { get; set; } = null!;
    [Column("post_title", TypeName = "text")]
    public string PostTitle { get; set; } = null!;
        [Column("post_excerpt", TypeName = "text")]
        public string PostExcerpt { get; set; } = null!;
        [Column("post_status")]
        [StringLength(20)]
        public string PostStatus { get; set; } = null!;
        [Column("comment_status")]
        [StringLength(20)]
        public string CommentStatus { get; set; } = null!;
        [Column("ping_status")]
        [StringLength(20)]
        public string PingStatus { get; set; } = null!;
        [Column("post_password")]
        [StringLength(255)]
        public string PostPassword { get; set; } = null!;
        [Column("post_name")]
        [StringLength(200)]
        public string PostName { get; set; } = null!;
        [Column("to_ping", TypeName = "text")]
        public string ToPing { get; set; } = null!;
        [Column("pinged", TypeName = "text")]
        public string Pinged { get; set; } = null!;
        [Column("post_modified", TypeName = "datetime")]
        public DateTime PostModified { get; set; }
        [Column("post_modified_gmt", TypeName = "datetime")]
        public DateTime PostModifiedGmt { get; set; }
        [Column("post_content_filtered")]
        public string PostContentFiltered { get; set; } = null!;
        [Column("post_parent", TypeName = "bigint(20) unsigned")]
        public ulong PostParent { get; set; }
        [Column("guid")]
        [StringLength(255)]
        public string Guid { get; set; } = null!;
        [Column("menu_order", TypeName = "int(11)")]
        public int MenuOrder { get; set; }
        [Column("post_type")]
        [StringLength(20)]
        public string PostType { get; set; } = null!;
        [Column("post_mime_type")]
        [StringLength(100)]
        public string PostMimeType { get; set; } = null!;
        [Column("comment_count", TypeName = "bigint(20)")]
        public long CommentCount { get; set; }
    }
}
