using UnityEngine;

namespace Assets.Homework10.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CoinSpawner _coinSpawner;

        private void Awake()
        {
            _coinSpawner.StartSpawn();
        }
    }
}
