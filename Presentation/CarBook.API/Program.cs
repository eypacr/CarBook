using CarBook.API.Extensions;
using CarBook.Application.Extensions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Servislerin doðru sýrayla eklenmesi
builder.Services.AddRepositories(builder.Configuration)
        .ApplicationMediaExt(builder.Configuration)
        .CQRSHandlersExt()
        .AddSwaggerGenExt()
        .AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

        });

var app = builder.Build();

app.UseConfigurePipelineExt();

app.MapControllers();

app.Run();
