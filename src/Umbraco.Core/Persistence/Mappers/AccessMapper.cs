﻿using System.Collections.Concurrent;
using Umbraco.Core.Models;
using Umbraco.Core.Persistence.Dtos;

namespace Umbraco.Core.Persistence.Mappers
{
    [MapperFor(typeof(PublicAccessEntry))]
    public sealed class AccessMapper : BaseMapper
    {
        private static readonly ConcurrentDictionary<string, DtoMapModel> PropertyInfoCacheInstance = new ConcurrentDictionary<string, DtoMapModel>();

        internal override ConcurrentDictionary<string, DtoMapModel> PropertyInfoCache => PropertyInfoCacheInstance;

        protected override void BuildMap()
        {
            CacheMap<PublicAccessEntry, AccessDto>(src => src.Key, dto => dto.Id);
            CacheMap<PublicAccessEntry, AccessDto>(src => src.LoginNodeId, dto => dto.LoginNodeId);
            CacheMap<PublicAccessEntry, AccessDto>(src => src.NoAccessNodeId, dto => dto.NoAccessNodeId);
            CacheMap<PublicAccessEntry, AccessDto>(src => src.ProtectedNodeId, dto => dto.NodeId);
            CacheMap<PublicAccessEntry, AccessDto>(src => src.CreateDate, dto => dto.CreateDate);
            CacheMap<PublicAccessEntry, AccessDto>(src => src.UpdateDate, dto => dto.UpdateDate);
        }
    }
}
