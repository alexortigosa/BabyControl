namespace AOTECH.BabyControl.Common.Domain.Common
{
    public interface IServiceBase
    {
    }

    public interface IService<in Tin, out Tout> : IServiceBase where Tin : IRequest
    {
        Tout Execute(Tin request);
    }
    public interface IServiceAsync<in Tin, out Tout> : IServiceBase where Tin : IRequest
    {
        Tout Execute(Tin request);
    }

    public interface IServiceIn<in Tin> : IServiceBase where Tin : IRequest
    {
        void Execute(Tin request);
    }

    public interface IService<out Tout> : IServiceBase
    {
        Tout Execute();
    }

    public interface IService : IServiceBase
    {
        void Execute();
    }
}