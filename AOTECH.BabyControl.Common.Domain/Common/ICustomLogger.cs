namespace AOTECH.BabyControl.Common.Domain.Common
{
    public interface ICustomLogger
    {
        void LogInformation(string info);
        void LogDebug(string info);
        void LogError(string info);
    }
}