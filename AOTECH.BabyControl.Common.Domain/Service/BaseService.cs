using AOTECH.BabyControl.Common.Domain.Common;
using Microsoft.Extensions.Logging;

namespace AOTECH.BabyControl.Common.Domain.Service
{
    public abstract class BaseService<TIn, TOut> : ActionBase<TIn, TOut>,IService<TIn,TOut> where TIn : IRequest
    {
        protected BaseService(ILogger logger) : base(logger)
        {
        }
    }
}