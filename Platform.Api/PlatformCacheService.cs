using Dargon.Hydar;

namespace Dargon.Platform {
   public interface PlatformCacheService {
      ICache<TKey, TValue> GetKeyValueCache<TKey, TValue>(string name);
   }
}
