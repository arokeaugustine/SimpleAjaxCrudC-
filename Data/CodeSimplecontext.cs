using Microsoft.EntityFrameworkCore;

namespace CodeSimpleCrud.Data
{
    public class CodeSimplecontext:DbContext
    {
        public CodeSimplecontext(DbContextOptions<CodeSimplecontext> options):base(options)
        {
            
        }
    }
}
