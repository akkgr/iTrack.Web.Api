using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace iTrack.Web.Api.Providers
{
    // sample persistence of refresh tokens
    // this is not production ready!
    public class RefreshTokenProvider : IAuthenticationTokenProvider
    {
        private static ConcurrentDictionary<string, AuthenticationTicket> _refreshTokens = new ConcurrentDictionary<string, AuthenticationTicket>();

        public async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            await Task.Run(() =>
                {
                    var guid = Guid.NewGuid().ToString();

                    // maybe only create a handle the first time, then re-use for same client
                    // copy properties and set the desired lifetime of refresh token
                    var refreshTokenProperties = new AuthenticationProperties(context.Ticket.Properties.Dictionary)
                    {
                        IssuedUtc = context.Ticket.Properties.IssuedUtc,
                        ExpiresUtc = DateTime.UtcNow.AddHours(2)
                    };
                    var refreshTokenTicket = new AuthenticationTicket(context.Ticket.Identity, refreshTokenProperties);

                    //_refreshTokens.TryAdd(guid, context.Ticket);
                    _refreshTokens.TryAdd(guid, refreshTokenTicket);

                    // consider storing only the hash of the handle
                    context.SetToken(guid);
                });
        }

        public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {
            await Task.Run(() =>
                {
                    AuthenticationTicket ticket;
                    if (_refreshTokens.TryRemove(context.Token, out ticket))
                    {
                        context.SetTicket(ticket);
                    }
                });
        }

        public async void Create(AuthenticationTokenCreateContext context)
        {
            await CreateAsync(context);
        }

        public async void Receive(AuthenticationTokenReceiveContext context)
        {
            await ReceiveAsync(context);
        }
    }
}