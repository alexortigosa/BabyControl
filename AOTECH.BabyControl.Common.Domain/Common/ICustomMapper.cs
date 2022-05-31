namespace AOTECH.BabyControl.Common.Domain.Common
{
    public interface ICustomMapper<in TIn, out TOut>
    {
        TOut Map(TIn input);
    }
}
