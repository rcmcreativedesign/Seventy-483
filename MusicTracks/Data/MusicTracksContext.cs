﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicTracks.Models;

namespace MusicTracks.Data
{
    public class MusicTracksContext : DbContext
    {
        public MusicTracksContext (DbContextOptions<MusicTracksContext> options)
            : base(options)
        {
        }

        public DbSet<MusicTracks.Models.MusicTrack> MusicTrack { get; set; }
    }
}
