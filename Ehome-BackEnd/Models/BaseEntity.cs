﻿using System;

namespace Ehome_BackEnd.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(4);
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
