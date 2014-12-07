using System.Text;
using Dargon.Hydar;

namespace Dargon.Platform {
   public class PlatformSystemStateImpl : SystemState {
      private readonly ICache<string, string> systemStateCache;

      public PlatformSystemStateImpl(ICache<string, string> systemStateCache) {
         this.systemStateCache = systemStateCache;
      }

      public string Get(string key, string defaultValue) {
         string value;
         if (!systemStateCache.TryGetValue(key, out value)) {
            value = defaultValue;
         }
         return value;
      }

      public void Set(string key, string value) {
         systemStateCache[key] = value;
      }

      public string DumpCacheContents() {
         var sb = new StringBuilder();
         var kvps = systemStateCache.GetAll();
         foreach (var kvp in kvps) {
            sb.AppendLine(kvp.Key + ": " + kvp.Value);
         }
         return sb.ToString();
      }
   }
}
