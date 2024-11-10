using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




app.UseCors("AllowAllOrigins"); // Sử dụng CORS

app.MapControllers();  // Nếu bạn dùng controller-based routing




app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();














//using Microsoft.Extensions.FileProviders;

//var builder = WebApplication.CreateBuilder(args);

//// Tạo và cấu hình ứng dụng
//var app = builder.Build();

//// Đảm bảo ứng dụng sử dụng tệp tĩnh
//app.UseStaticFiles(); // Cho phép truy cập vào wwwroot

//// Cấu hình đường dẫn tĩnh cho thư mục CKFinder
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(
//        Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "ckfinder")),
//    RequestPath = "/ckfinder"
//});

//app.UseRouting();

//// Khởi động ứng dụng
//app.Run();














//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;

//var builder = WebApplication.CreateBuilder(args);

//// Cấu hình dịch vụ CORS
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAllOrigins", policy =>
//    {
//        policy.AllowAnyOrigin()
//              .AllowAnyMethod()
//              .AllowAnyHeader();
//    });
//});

//// Thêm dịch vụ MVC
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Cấu hình CORS để sử dụng cho tất cả các yêu cầu
//app.UseRouting();
//app.UseCors("AllowAllOrigins");

//// Cấu hình route mặc định cho MVC
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
