﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commands;

namespace eShop.Identity.User.Events
{
    public interface Disabled : IStampedEvent
    {
        string UserName { get; set; }
    }
}
