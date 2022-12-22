using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSQLite;


/// <summary>
/// 東京卸売市場のデータアクセス
/// </summary>
public class FisheriesDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.db";
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
    public DbSet<Users> Users => Set<Users>();
    public DbSet<T卸売> T卸売 => Set<T卸売>();
    public DbSet<T品名> T品名 => Set<T品名>();
    public DbSet<T市場> T市場 => Set<T市場>();
    public DbSet<T販売方法> T販売方法 => Set<T販売方法>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Users>().ToTable("Users");
        // modelBuilder.Entity<T卸売>().ToTable("T卸売");
    }

}

public class T卸売
{
    [Key]
    public int Id { get; set; }
    public int 品名Id {  get; set; }
    public int 販売方法Id { get; set; }
    public int 市場Id { get; set; }
    public int 卸売数 { get; set; }
    public DateTime 日付 { get; set; }

    public T品名 品名 { get; set; }
    public T市場 市場 { get; set; }
    public T販売方法 販売方法 { get; set; }
}
public class T品名
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

}
public class T市場
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
public class T販売方法
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}

public class T水産
{
    [Key]
    public int Id { get; set; }
    public DateTime 日付 { get; set; }
    public string 棟 { get; set; }
    public string 分類 { get; set; }
    public string 市場名 { get; set; }
    public string 品名 { get; set; }
    public string 販売方法 { get; set; }
    public double 卸売数量 { get; set; }
}

public class Users
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
