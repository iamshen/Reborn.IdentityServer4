/*
 Copyright (c) 2024 Iamshen . All rights reserved.

 Copyright (c) 2024 HigginsSoft, Alexander Higgins - https://github.com/alexhiggins732/ 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code and license this software can be found 

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.
*/

using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace IdentityServer.UnitTests.Endpoints.EndSession
{
    internal class StubBackChannelLogoutClient : IBackChannelLogoutService
    {
        public bool SendLogoutsWasCalled { get; set; }

        public Task SendLogoutNotificationsAsync(LogoutNotificationContext context)
        {
            SendLogoutsWasCalled = true;
            return Task.CompletedTask;
        }
    }
}
