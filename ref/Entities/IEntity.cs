﻿using System.Threading.Tasks;

namespace Discord
{
    public interface IEntity<TId> : IEntity
    {
        /// <summary> Gets the unique identifier for this object. </summary>
        TId Id { get; }
    }
    public interface IEntity
    {
        /// <summary> Gets the DiscordClient that manages this object. </summary>
        DiscordClient Discord { get; }
        /// <summary> Gets the state of this object. </summary>
        EntityState State { get; }
        
        /// <summary> Downloads the latest values and updates this object. </summary>
        Task Update();
    }
}
