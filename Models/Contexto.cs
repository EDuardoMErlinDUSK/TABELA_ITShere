using Microsoft.EntityFrameworkCore;

namespace ProjetoSEMESTRE.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Observacoes> Observacoes { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        //public DbSet<Cozinheiro> Cozinheiro { get; set; }
        //public DbSet<Pratos> Pratos { get; set; }
        //public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<Pagamento> Pagamento { get; set; }
        //public DbSet<Atendente> Atendente { get; set; }
        //public DbSet<Pedido> Pedido { get; set; }
        //public DbSet<PedidoPrato> PedidoPrato { get; set; }
    }
}
