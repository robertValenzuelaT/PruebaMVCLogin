using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PruebaMVCLogin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaMVCLogin.Models.Contact> DataContacts { get; set; }
        public DbSet<PruebaMVCLogin.Models.Product> DataProducts { get; set; }
        public DbSet<PruebaMVCLogin.Models.Proforma> DataProforma { get; set; }
        public DbSet<PruebaMVCLogin.Models.Pago> DataPago { get; set; }
        public DbSet<PruebaMVCLogin.Models.Pedido> DataPedido { get; set; }
        public DbSet<PruebaMVCLogin.Models.DetallePedido> DataDetallePedido { get; set; }
        
    }
}
