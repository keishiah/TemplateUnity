using CodeBase.UI.HUD;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Factories
{
    public class GameFactoryInstaller : Installer<GameFactoryInstaller>
    {
        public override void InstallBindings()
        {
            // bind sub-factories here
            Container.BindFactory<HUDRoot, HUDRoot.Factory>()
                .FromComponentInNewPrefabResource(InfrastructureAssetPath.HUDRoot);

            Container.BindFactory<float, Cube, Cube.Factory>().FromNewComponentOnNewGameObject()
                .UnderTransform(GameObject.Find("GameRunner").transform);


            Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();
        }
    }
}