using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MauiMySQL.Models
{
    public partial class wpdbContext : DbContext
    {
        public wpdbContext()
        {
        }

        public wpdbContext(DbContextOptions<wpdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WpComment> WpComments { get; set; } 
        public virtual DbSet<WpCommentmetum> WpCommentmeta { get; set; }
        public virtual DbSet<WpLink> WpLinks { get; set; }
        public virtual DbSet<WpOption> WpOptions { get; set; }
        public virtual DbSet<WpPost> WpPosts { get; set; }
        public virtual DbSet<WpPostmetum> WpPostmeta { get; set; }
        public virtual DbSet<WpTerm> WpTerms { get; set; } 
        public virtual DbSet<WpTermRelationship> WpTermRelationships { get; set; }
        public virtual DbSet<WpTermTaxonomy> WpTermTaxonomies { get; set; }
        public virtual DbSet<WpTermmetum> WpTermmeta { get; set; }
        public virtual DbSet<WpUser> WpUsers { get; set; } 
        public virtual DbSet<WpUsermetum> WpUsermeta { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=wpuser;database=wpdb;password=wppass", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.1.38-mariadb"));
            }
        }

#if true
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<WpComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.Property(e => e.CommentAgent).HasDefaultValueSql("''");

                entity.Property(e => e.CommentApproved).HasDefaultValueSql("'1'");

                entity.Property(e => e.CommentAuthorEmail).HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorIp).HasDefaultValueSql("''");

                entity.Property(e => e.CommentAuthorUrl).HasDefaultValueSql("''");

                entity.Property(e => e.CommentDate).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentDateGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentType).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpCommentmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });
            });

            modelBuilder.Entity<WpLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.Property(e => e.LinkDescription).HasDefaultValueSql("''");

                entity.Property(e => e.LinkImage).HasDefaultValueSql("''");

                entity.Property(e => e.LinkName).HasDefaultValueSql("''");

                entity.Property(e => e.LinkOwner).HasDefaultValueSql("'1'");

                entity.Property(e => e.LinkRel).HasDefaultValueSql("''");

                entity.Property(e => e.LinkRss).HasDefaultValueSql("''");

                entity.Property(e => e.LinkTarget).HasDefaultValueSql("''");

                entity.Property(e => e.LinkUpdated).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LinkUrl).HasDefaultValueSql("''");

                entity.Property(e => e.LinkVisible).HasDefaultValueSql("'Y'");
            });

            modelBuilder.Entity<WpOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.Property(e => e.Autoload).HasDefaultValueSql("'yes'");

                entity.Property(e => e.OptionName).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpPost>(entity =>
            {
                entity.HasIndex(e => e.PostName, "post_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.CommentStatus).HasDefaultValueSql("'open'");

                entity.Property(e => e.Guid).HasDefaultValueSql("''");

                entity.Property(e => e.PingStatus).HasDefaultValueSql("'open'");

                entity.Property(e => e.PostDate).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostDateGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostMimeType).HasDefaultValueSql("''");

                entity.Property(e => e.PostModified).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostModifiedGmt).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostName).HasDefaultValueSql("''");

                entity.Property(e => e.PostPassword).HasDefaultValueSql("''");

                entity.Property(e => e.PostStatus).HasDefaultValueSql("'publish'");

                entity.Property(e => e.PostType).HasDefaultValueSql("'post'");
            });

            modelBuilder.Entity<WpPostmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });
            });

            modelBuilder.Entity<WpTerm>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Name, "name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Slug, "slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.Name).HasDefaultValueSql("''");

                entity.Property(e => e.Slug).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpTermRelationship>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasKey(e => e.TermTaxonomyId)
                    .HasName("PRIMARY");

                entity.Property(e => e.Taxonomy).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpTermmetum>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });
            });

            modelBuilder.Entity<WpUser>(entity =>
            {
                entity.Property(e => e.DisplayName).HasDefaultValueSql("''");

                entity.Property(e => e.UserActivationKey).HasDefaultValueSql("''");

                entity.Property(e => e.UserEmail).HasDefaultValueSql("''");

                entity.Property(e => e.UserLogin).HasDefaultValueSql("''");

                entity.Property(e => e.UserNicename).HasDefaultValueSql("''");

                entity.Property(e => e.UserPass).HasDefaultValueSql("''");

                entity.Property(e => e.UserRegistered).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserUrl).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WpUsermetum>(entity =>
            {
                entity.HasKey(e => e.UmetaId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MetaKey, "meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
#endif
    }
}
