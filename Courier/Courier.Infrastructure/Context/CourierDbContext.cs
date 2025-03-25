using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Courier.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Courier.Infrastructure.Context
{
    public class CourierContext : DbContext
    {
        public CourierContext(DbContextOptions<CourierContext> options)
            : base(options)
        {
        }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<User> Users { get; set; }

       

    }

}
