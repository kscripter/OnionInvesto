﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnionInvesto.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }
    }

}
