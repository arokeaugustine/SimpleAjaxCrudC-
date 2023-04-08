using CodeSimpleCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSimpleCrud.Data
{
    public class CodeSimpleContext:DbContext
    {
        public CodeSimpleContext(DbContextOptions<CodeSimpleContext> options):base(options)
        {
            
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
