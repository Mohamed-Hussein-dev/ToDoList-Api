using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;
using ToDo.Infrastructure.Common.Persistence;
using ToDo.Infrastructure.Tasks.Persistence;

namespace ToDo.Infrastructure
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services , IConfiguration configuration)
        {
            return services.AddPersistence(configuration);

        }
        public static IServiceCollection AddPersistence(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(
                "Server=.;Database=ToDoListDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));

            services.AddScoped<ITaskRepostory, TaskRepostory>();


            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
            })
                .AddEntityFrameworkStores<ToDoDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false; // to make it an work at any protocol like http,https
                o.SaveToken = false;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"])),

                    ValidateIssuer = true,
                    ValidIssuer = configuration["JWT:Issuer"],

                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:Audience"],

                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero // To Strict validation of token expiration
                };
            });


           

            services.AddScoped<ITokenGenerator , JwtTokenGenerator>();

            return services;
        }
    }
}
