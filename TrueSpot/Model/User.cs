﻿namespace TrueSpot.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
    }
}
