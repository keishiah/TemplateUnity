using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Factories
{
    public class Cube : MonoBehaviour, ICube
    {
        [Inject]
        void Construct(float number)
        {
            print(number);
        }


        public void move()
        {
            Debug.Log("move");
        }

        public class Factory : PlaceholderFactory<float, Cube>
        {
        }
    }
}