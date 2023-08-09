using CodeBase.Infrastructure.States;
using CodeBase.UI.HUD;

namespace CodeBase.Infrastructure.Factories
{
    public class GameFactory : IGameFactory
    {
        private readonly HUDRoot.Factory hudFactory;

        public Cube.Factory _cubeFactory;

        public ICube Cube;


        public GameFactory(HUDRoot.Factory hudFactory, Cube.Factory cubeFactory)
        {
            this.hudFactory = hudFactory;
            _cubeFactory = cubeFactory;
        }

        public IHUDRoot CreateHUD() => hudFactory.Create();
        public ICube CreateCube() => _cubeFactory.Create(12f);

        public void Cleanup()
        {
        }
    }
}