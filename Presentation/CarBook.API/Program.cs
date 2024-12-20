using CarBook.API.Extensions;
using CarBook.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Servislerin doðru sýrayla eklenmesi
builder.Services.AddRepositories(builder.Configuration)
        .ApplicationMediaExt(builder.Configuration)
        .CQRSHandlersExt()
        .AddSwaggerGenExt()
        .AddControllers();

var app = builder.Build();

app.UseConfigurePipelineExt();

app.MapControllers();

app.Run();
