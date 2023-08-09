using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.States;
using UnityEngine;
using Zenject;

namespace CodeBase
{
    public class Test : MonoBehaviour
    {
        private IGameFactory gameFactory;
        public GameObject cube;

        [Inject]
        void Construct(IGameFactory gamefactory)
        {
            this.gameFactory = gamefactory;
            var cube1 = gamefactory.CreateCube();
        }
    }
}