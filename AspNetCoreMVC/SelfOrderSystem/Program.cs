using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//　追加
builder.Services.AddDbContext<AppDbContext>(
        options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
/////////


// builder.Services.AddDbContext<AppDbContext>(...) の後へ追加する
 //　追加
builder.Services.AddDistributedMemoryCache();                    // Sessionの保存領域 

builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromHours(2);                 // 2時間で期限切れ 
    options.Cookie.HttpOnly = true;                              // JavaScriptから参照禁止 
    options.Cookie.IsEssential = true;                           // 必須Cookie 
});

builder.Services.AddHttpContextAccessor();                       // HttpContextをServiceで取得 
builder.Services.AddScoped<CartService>();                       // CartServiceをDIへ登録 
/////////


var app = builder.Build();

//　追加 
if (app.Environment.IsDevelopment()) {
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await SeedData.InitializeAsync(db);
}
/////////


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//　追加
app.UseSession();   // Controller実行前にSessionを有効化 
/////////


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
