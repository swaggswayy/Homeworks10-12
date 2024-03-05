using UnityEngine;

namespace Assets.Homework10.Scripts
{
    [CreateAssetMenu(menuName = "Factory/CoinFactory")]
    public class CoinFactory : ScriptableObject
    {
        [SerializeField] Coin _coin;

        public Coin Spawn(SpawnPoint spawnPoint)
        {
            Coin coin = Instantiate(_coin, spawnPoint.transform);
            return coin;
        }
    }
}
