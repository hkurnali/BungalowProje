using BussinesLayer.Abstract;
using BussinesLayer.Concrate;
using DataAccessLayer.Abstact;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFrameWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();

builder.Services.AddScoped<ITeamDal, EfTeamDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();


builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();


builder.Services.AddScoped<IIndexSliderDal, EfIndexSliderDal>();
builder.Services.AddScoped<IIndexSliderService, IndexSliderManager>();


builder.Services.AddScoped<IIndexVideoDal, EfIndexVideoDal>();
builder.Services.AddScoped<IIndexVideoService, IndexVideoManager>();

builder.Services.AddScoped<IAboutUsDal, EfAboutUsDal>();
builder.Services.AddScoped<IAboutUsService, AboutUsManager>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
