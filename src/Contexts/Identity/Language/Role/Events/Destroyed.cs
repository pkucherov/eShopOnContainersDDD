﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commands;

namespace eShop.Identity.Role.Events
{
    public interface Destroyed : IStampedEvent
    {
        Guid RoleId { get; set; }
    }
}
