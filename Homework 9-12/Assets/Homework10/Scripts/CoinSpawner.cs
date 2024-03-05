using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Homework10.Scripts
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private List<SpawnPoint> _spawnPoints;
        [SerializeField] private CoinFactory _coinFactory;
        [SerializeField] private float _spawnCooldown;

        private Coroutine _spawn;

        public void StartSpawn()
        {
            StopSpawn();

            _spawn = StartCoroutine(Spawn());
        }

        private void StopSpawn()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                for (int i = 0; i < _spawnPoints.Count; i++)
                {
                    SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
                    if (spawnPoint.IsBusy == false)
                    {
                        _coinFactory.Spawn(spawnPoint);
                        spawnPoint.CheckForBusy();
                        break;
                    }
                }
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
    }
}
