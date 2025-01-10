using CarBook.API.Extensions;
using CarBook.Application.Extensions;
using CarBook.Application.Tools.AuthenticationTools;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


//JWT Bearer Konfigürasyonu
builder.Services.AddJwtAuthentication();

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
app.UseAuthentication();
app.MapControllers();

app.Run();
