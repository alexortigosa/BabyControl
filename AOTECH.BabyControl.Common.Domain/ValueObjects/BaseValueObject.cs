namespace AOTECH.BabyControl.Common.Domain.ValueObjects
{
    public abstract class BaseValueObject<TOut> : IValueObject<TOut>
    {
        public abstract TOut Get();

        protected abstract void _validate();
    }
}
