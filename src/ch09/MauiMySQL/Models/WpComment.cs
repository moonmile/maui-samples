using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL.Models
{
    [Table("wp_comments")]
    [Index(nameof(CommentApproved), nameof(CommentDateGmt), Name = "comment_approved_date_gmt")]
    [Index(nameof(CommentDateGmt), Name = "comment_date_gmt")]
    [Index(nameof(CommentParent), Name = "comment_parent")]
    [Index(nameof(CommentPostId), Name = "comment_post_ID")]
    [MySqlCharSet("utf8mb4")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class WpComment
    {
        [Key]
        [Column("comment_ID", TypeName = "bigint(20) unsigned")]
        public ulong CommentId { get; set; }
        [Column("comment_post_ID", TypeName = "bigint(20) unsigned")]
        public ulong CommentPostId { get; set; }
        [Column("comment_author", TypeName = "tinytext")]
        public string CommentAuthor { get; set; } = null!;
        [Column("comment_author_email")]
        [StringLength(100)]
        public string CommentAuthorEmail { get; set; } = null!;
        [Column("comment_author_url")]
        [StringLength(200)]
        public string CommentAuthorUrl { get; set; } = null!;
        [Column("comment_author_IP")]
        [StringLength(100)]
        public string CommentAuthorIp { get; set; } = null!;
        [Column("comment_date", TypeName = "datetime")]
        public DateTime CommentDate { get; set; }
        [Column("comment_date_gmt", TypeName = "datetime")]
        public DateTime CommentDateGmt { get; set; }
        [Column("comment_content", TypeName = "text")]
        public string CommentContent { get; set; } = null!;
        [Column("comment_karma", TypeName = "int(11)")]
        public int CommentKarma { get; set; }
        [Column("comment_approved")]
        [StringLength(20)]
        public string CommentApproved { get; set; } = null!;
        [Column("comment_agent")]
        [StringLength(255)]
        public string CommentAgent { get; set; } = null!;
        [Column("comment_type")]
        [StringLength(20)]
        public string CommentType { get; set; } = null!;
        [Column("comment_parent", TypeName = "bigint(20) unsigned")]
        public ulong CommentParent { get; set; }
        [Column("user_id", TypeName = "bigint(20) unsigned")]
        public ulong UserId { get; set; }
    }
}
