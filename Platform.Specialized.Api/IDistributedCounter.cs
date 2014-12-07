namespace Dargon.Platform.Specialized {
   public interface IDistributedCounter {
      long PeekCurrentValue();
      long TakeNextValue();
   }
}
