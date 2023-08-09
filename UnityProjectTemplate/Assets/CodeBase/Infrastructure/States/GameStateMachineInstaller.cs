using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.States
{
    public class GameStateMachineInstaller : Installer<GameStateMachineInstaller>
    {
        public override void InstallBindings()
        {
            //So when something in your code asks for a IGameStateMachine, Zenject should use the BootstrapState.Factory to create an instance of BootstrapState.
            Container.BindFactory<IGameStateMachine, BootstrapState, BootstrapState.Factory>();
            Container.BindFactory<IGameStateMachine, LoadPlayerProgressState, LoadPlayerProgressState.Factory>();
            Container.BindFactory<IGameStateMachine, LoadLevelState, LoadLevelState.Factory>();

            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
        }
    }
}