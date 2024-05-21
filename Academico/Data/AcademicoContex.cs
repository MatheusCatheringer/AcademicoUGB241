using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class AcademicoContex : DbContext
    {
        public AcademicoContex(DbContextOptions<AcademicoContex> options) : base(options)
        {
        }
        public DbSet<Instituicao> Instituicoes { get; set; }
    }
}
