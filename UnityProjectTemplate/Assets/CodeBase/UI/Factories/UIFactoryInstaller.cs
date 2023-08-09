using Zenject;

namespace CodeBase.UI.Factories
{
    public class UIFactoryInstaller : Installer<UIFactoryInstaller>
    {
        public override void InstallBindings()
        {
            // здесь биндим основную фабрику UI и возможное субфабрики. Пока хз зачем.
            
            Container.Bind<IUIFactory>().To<UIFactory>().AsSingle();
        }
    }
}