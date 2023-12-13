using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MyApi.Models.Jwt;

public class JwtContext : IdentityDbContext<User>
{
    public JwtContext(DbContextOptions<JwtContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("jwt");
            base.OnModelCreating(builder);
        }
}