﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Models;

namespace SoftCinema.Data.Configurations
{
    public class SeatsConfiguration : EntityTypeConfiguration<Seat>
    {
        public SeatsConfiguration()
        {
            this.HasRequired(s => s.Auditorium)
                .WithMany(a => a.Seats)
                .WillCascadeOnDelete(false);
        }
    }
}
