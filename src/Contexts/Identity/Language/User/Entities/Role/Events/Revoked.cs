﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commands;

namespace eShop.Identity.User.Entities.Role.Events
{
    public interface Revoked : IStampedEvent
    {
        Guid UserId { get; set; }
        Guid RoleId { get; set; }
    }
}
