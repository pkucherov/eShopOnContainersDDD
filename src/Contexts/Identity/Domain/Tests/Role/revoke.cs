﻿using Aggregates;
using Aggregates.Exceptions;
using Infrastructure.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace eShop.Identity.Role
{
    public class revoke
    {
        [Theory, AutoFakeItEasyData]
        public async Task Should_revoke(
            TestableContext context,
            Handler handler
            )
        {
            context.UoW.Plan<Role>(context.Id())
                .HasEvent<Events.Defined>(x =>
                {
                    x.RoleId = context.Id();
                });

            var command = new Commands.Revoke
            {
                RoleId = context.Id()
            };
            await handler.Handle(command, context).ConfigureAwait(false);

            context.UoW.Check<Role>(context.Id()).Raised<Events.Revoked>();

        }
        [Theory, AutoFakeItEasyData]
        public async Task Should_not_revoke_destroyed(
            TestableContext context,
            Handler handler
            )
        {
            context.UoW.Plan<Role>(context.Id())
                .HasEvent<Events.Defined>(x =>
                {
                    x.RoleId = context.Id();
                })
                .HasEvent<Events.Destroyed>(x =>
                {
                    x.RoleId = context.Id();
                });

            var command = new Commands.Revoke
            {
                RoleId = context.Id()
            };

            await Assert.ThrowsAsync<BusinessException>(() => handler.Handle(command, context)).ConfigureAwait(false);

        }
    }
}
