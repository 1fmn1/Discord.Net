﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
	public class Server : IEntity<ulong>
    {
        public class Emoji
        {
            public string Id { get; }
            public string Name { get; }
            public bool IsManaged { get; }
            public bool RequireColons { get; }
            public IEnumerable<Role> Roles { get; }
        }
        
        public ulong Id { get; }
        public DiscordClient Discord { get; }
        public EntityState State { get; }

        public ServerUser CurrentUser { get; }
        public string IconId { get; }
        public string SplashId { get; }
        public string IconUrl { get; }
        public string SplashUrl { get; }
        public int ChannelCount { get; }
        public int UserCount { get; }
        public int RoleCount { get; }
        public TextChannel DefaultChannel { get; } 
        public Role EveryoneRole { get; }
        public IEnumerable<string> Features { get; }
        public IEnumerable<Emoji> CustomEmojis { get; }
        public IEnumerable<IChannel> Channels { get; }
        public IEnumerable<TextChannel> TextChannels { get; }
        public IEnumerable<VoiceChannel> VoiceChannels { get; }
        public IEnumerable<ServerUser> Users { get; }
        public IEnumerable<Role> Roles { get; }

        public string Name { get; set; }
        public Region Region { get; set; }
        public int AFKTimeout { get; set; }
        public DateTime JoinedAt { get; set; }
        public ServerUser Owner { get; set; }                
        public VoiceChannel AFKChannel { get; set; }        
                
        public Task<IPublicChannel> GetChannel(ulong id) => null;
        public Task<IPublicChannel> GetChannel(string mention) => null;
        public Task<Role> GetRole(ulong id) => null;
        public Task<ServerUser> GetUser(ulong id) => null;
        public Task<ServerUser> GetUser(string name, ushort discriminator) => null;
        public Task<ServerUser> GetUser(string mention) => null;
        public Task<IEnumerable<ServerUser>> GetBans() => null;
        public Task<IEnumerable<Invite>> GetInvites() => null;

        public Task<TextChannel> CreateTextChannel(string name) => null;
        public Task<VoiceChannel> CreateVoiceChannel(string name) => null;
        public Task<Invite> CreateInvite(int? maxAge = 1800, int? maxUses = null, bool tempMembership = false, bool withXkcd = false) => null;
        public Task<Role> CreateRole(string name, ServerPermissions? permissions = null, Color color = null, bool isHoisted = false) => null;
        
        public Task<int> PruneUsers(int days = 30, bool simulate = false) => null;

        public Task Update() => null;
        public Task Leave() => null;
        public Task Delete() => null;
    }
}
