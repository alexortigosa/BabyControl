namespace AOTECH.BabyControl.Common.Domain.Common
{
    public interface IRepository<in TIn, TOut>
    {
        Task<TOut> Add(TIn eventEntity);
        Task<TOut> Read(TIn eventEntity);
        Task<IEnumerable<TOut>> Get();
        Task<TOut> Get(string id);        
        Task<TOut> Delete(string id);
        Task Update(Guid eventId, IDictionary<string, object> valuePairs);
    }
}
