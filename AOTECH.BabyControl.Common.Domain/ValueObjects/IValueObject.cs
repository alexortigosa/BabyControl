namespace AOTECH.BabyControl.Common.Domain.ValueObjects
{
    public interface IValueObject<out TOut>
    {
        TOut Get();
    }
}
