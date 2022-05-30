using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvaTecnica_ControleAlugueis.Models;

namespace ProvaTecnica_ControleAlugueis.Data
{
    public class ProvaTecnica_ControleAlugueisContext : DbContext
    {
        public ProvaTecnica_ControleAlugueisContext (DbContextOptions<ProvaTecnica_ControleAlugueisContext> options)
            : base(options)
        {
        }

        public DbSet<ProvaTecnica_ControleAlugueis.Models.Cliente> Cliente { get; set; }

        public DbSet<ProvaTecnica_ControleAlugueis.Models.Ferramenta> Ferramenta { get; set; }

        public DbSet<ProvaTecnica_ControleAlugueis.Models.Loja> Loja { get; set; }

        public DbSet<ProvaTecnica_ControleAlugueis.Models.Solicitacao> Solicitacao { get; set; }
    }
}
