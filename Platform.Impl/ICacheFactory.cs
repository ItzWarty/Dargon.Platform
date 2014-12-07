using System.Collections.Generic;
using Dargon.Hydar;

namespace Dargon.Platform {
   public interface ICacheFactory {
      ICache<TKey, TValue> CreatePersistentCache<TKey, TValue>(string name, IReadOnlyList<ICacheIndex> indices);
      ICacheIndex<TKey, TValue, TProjection> CreatePersistentCacheIndex<TKey, TValue, TProjection>(string name, ICacheProjector<TKey, TValue, TProjection> projector);
   }
}