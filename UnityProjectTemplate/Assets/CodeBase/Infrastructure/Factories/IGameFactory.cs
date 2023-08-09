using CodeBase.UI.HUD;

namespace CodeBase.Infrastructure.Factories
{
    public interface IGameFactory
    {
        IHUDRoot CreateHUD();
        ICube CreateCube();
        void Cleanup();
    }
}