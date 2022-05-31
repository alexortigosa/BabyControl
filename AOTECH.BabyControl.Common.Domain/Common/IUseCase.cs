namespace AOTECH.BabyControl.Common.Domain.Common
{
    public interface IUseCaseBase
    {
    }

    public interface IUseCase<in Tin, out Tout> : IUseCaseBase where Tin : IRequest
    {
        Tout Execute(Tin request);
    }

    public interface IUseCaseOut<out Tout> : IUseCaseBase
    {
        Tout Execute();
    }

    public interface IUseCaseIn<in Tin> : IUseCaseBase where Tin : IRequest
    {
        void Execute(Tin request);
    }

    public interface IUseCaseVoid : IUseCaseBase
    {
        void Execute();
    }
}