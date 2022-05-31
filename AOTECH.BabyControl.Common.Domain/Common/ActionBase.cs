using Microsoft.Extensions.Logging;

namespace AOTECH.BabyControl.Common.Domain.Common
{
    public abstract class ActionBase<TIn, TOut>
    {
        private readonly ILogger _logger;
        
        protected ActionBase(
            ILogger logger
        )
        {
            _logger = logger
                      ?? throw new ArgumentNullException(nameof(logger));
        }
        
        public TOut Execute(TIn request)
        {
            try
            {
                _logger.LogTrace($"{nameof(ActionBase<TIn,TOut>)} Inicio {nameof(Execute)}");
                var result = InnerExecute(request);
                _logger.LogTrace($"{nameof(ActionBase<TIn,TOut>)} Fin {nameof(Execute)}.");
                return result;
            }
            catch (Exception e)
            {
                ManageException(e);
                throw;
            }
        }
        protected virtual void ManageException(Exception e)
        {
            var errMsg = e.InnerException == null ? e.Message : e.InnerException.Message;
            _logger.LogCritical(e, $"{nameof(ActionBase<TIn,TOut>)} {nameof(Execute)} Exception: {errMsg}");
        }
        protected abstract TOut InnerExecute(TIn input);
    }
    
    public abstract class ActionBase<TIn>
    {
        private readonly ILogger _logger;
        
        protected ActionBase(
            ILogger logger
        )
        {
            _logger = logger
                      ?? throw new ArgumentNullException(nameof(logger));
        }
        
        public void Execute(TIn request)
        {
            try
            {
                _logger.LogTrace($"{nameof(ActionBase<TIn>)} Inicio {nameof(Execute)}");
                InnerExecute(request);
                _logger.LogTrace($"{nameof(ActionBase<TIn>)} Fin {nameof(Execute)}.");
            }
            catch (Exception e)
            {
                ManageException(e);
                throw;
            }
        }
        protected virtual void ManageException(Exception e)
        {
            var errMsg = e.InnerException == null ? e.Message : e.InnerException.Message;
            _logger.LogCritical(e, $"{nameof(ActionBase<TIn>)} {nameof(Execute)} Exception: {errMsg}");
        }
        protected abstract void InnerExecute(TIn input);
    }
}