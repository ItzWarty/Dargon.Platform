namespace Dargon.Platform.Specialized {
   public interface SpecializedCacheService {
      IDistributedCounter GetCountingCache(string name);
   }
}
