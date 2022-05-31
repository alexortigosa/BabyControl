using AOTECH.BabyControl.Common.Domain.Common;
using Microsoft.Extensions.Logging;

namespace AOTECH.BabyControl.Common.Domain.UseCase
{
    public abstract class BaseUseCase<TIn, TOut> : ActionBase<TIn, TOut>,IUseCase<TIn,TOut> where TIn : IRequest
    {
        protected BaseUseCase(ILogger logger) : base(logger)
        {
        }
    }
    public abstract class BaseUseCase<TIn> : ActionBase<TIn>,IUseCaseIn<TIn> where TIn : IRequest
    {
        protected BaseUseCase(ILogger logger) : base(logger)
        {
        }
    }
}