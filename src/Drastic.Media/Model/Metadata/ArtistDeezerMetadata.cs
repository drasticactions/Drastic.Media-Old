﻿// <copyright file="ArtistDeezerMetadata.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace Drastic.Media.Core.Model.Metadata
{
    public class ArtistDeezerMetadata : IArtistMetadata
    {
        public ArtistDeezerMetadata()
        {
        }

        public ArtistDeezerMetadata(int artistId)
        {
            if (artistId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(artistId), "Must be higher than 0");
            }

            this.ArtistItemId = artistId;
            this.LastUpdated = DateTime.Now;
        }

        public string Type => this.GetType().Name;

        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Image { get; set; }

        public DateTime? LastUpdated { get; set; }

        public int ArtistItemId { get; set; }

        public virtual ArtistItem? ArtistItem { get; set; }
    }
}
