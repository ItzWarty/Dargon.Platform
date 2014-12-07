using Dargon.Management;

namespace Dargon.Platform {
   public class PlatformSystemStateMob {
      private readonly PlatformSystemStateImpl platformSystemState;

      public PlatformSystemStateMob(PlatformSystemStateImpl platformSystemState) {
         this.platformSystemState = platformSystemState;
      }

      [ManagedOperation]
      public string DumpCacheContents() {
         return platformSystemState.DumpCacheContents();
      }

      [ManagedOperation]
      public string Get(string key) {
         return platformSystemState.Get(key, null);
      }

      [ManagedOperation]
      public void Set(string key, string value) {
         platformSystemState.Set(key, value);
      }
   }
}
