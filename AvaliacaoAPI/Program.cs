using AvaliacaoAPI.Data;
using AvaliacaoAPI.Interface.Repository;
using AvaliacaoAPI.Interface.Service;
using AvaliacaoAPI.Repository;
using AvaliacaoAPI.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AvaliacaoConnection");

// Configuração do Entity Framework Core
builder.Services.AddDbContext<AvaliacaoContext>(opts => opts.UseSqlServer(connectionString));

//// Configuração do Identity
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//    .AddEntityFrameworkStores<SqlContext>()
//    .AddDefaultTokenProviders();

// Configuração do Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Avaliação de funcionários", Version = "v1" });
});

// Configuração dos outros serviços
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
//builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ISupervisorRepository, SupervisorRepository>();
builder.Services.AddScoped<ISupervisorService, SupervisorService>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();
builder.Services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
builder.Services.AddScoped<IAvaliacaoService, AvaliacaoService>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Avaliação de funcionários"));
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(p => {
    p.AllowAnyMethod();
    p.AllowAnyHeader();
    p.AllowAnyOrigin();
});
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});

app.Run();
