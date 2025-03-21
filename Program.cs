using AssuranceSNTL.Data;
using AssuranceSNTL.Portfiles;
using AssuranceSNTL.Repository.Implementation;
using AssuranceSNTL.Repository.Interface;
using AssuranceSNTL.Service.Implementation;
using AssuranceSNTL.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<AppDbContext>(options =>
  //  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(PackAssuranceMapper), typeof(TypeAssuranceMapper), typeof(ContratMapper));
builder.Services.AddScoped<IPackAssuranceRepo, PackAssuranceRepo>();
builder.Services.AddScoped<ITypeAssuranceRepo, TypeAssuranceRepo>();
builder.Services.AddScoped<IPackAssuranceManager, PackAssuranceManagerImpl>();
builder.Services.AddScoped<ITypeAssuranceManager, TypeAssuranceManagerImpl>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
