﻿namespace TrueSpot.Models
{
    public class TrueSpotUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
    }
}