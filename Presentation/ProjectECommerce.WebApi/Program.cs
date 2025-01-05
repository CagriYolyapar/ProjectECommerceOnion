using ProjectECommerce.Persistence.DependencyResolvers;
using ProjectECommerce.InnerInfrastructure.DependencyResolvers;
using Project.APPLICATION.DependencyResolvers;
using ProjectECommerce.WebApi.DependencyResolvers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddVmMapperInjection();
builder.Services.AddMapperInjection();
builder.Services.AddDbContextService();
builder.Services.AddRepositoryServices();
builder.Services.AddManagerServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
