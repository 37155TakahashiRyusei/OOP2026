using Microsoft.EntityFrameworkCore;  // EF Core を使用 
using MvcBasicSample.Models; // Product を使用

namespace MvcBasicSample.Data;
// EF Core を使ってデータベースへ接続するクラス 
public class AppDbContext : DbContext {
    // Program.cs で登録した接続設定を受け取る 
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    // 受け取った設定を親クラスへ渡す 
    {
    }
    // Products テーブルをProduct型として問い合わせるためのプロパティ 
    public DbSet<Product> Products => Set<Product>();
}

