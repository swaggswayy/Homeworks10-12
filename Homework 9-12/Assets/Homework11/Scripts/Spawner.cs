using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Homework11.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<SpawnPoint> spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private float _maxSpawnerWeight;

        private EnemyVisitor _enemyVisitor;
        private Coroutine _spawn;

        private void OnValidate()
        {
            if (_maxSpawnerWeight < 0)
            {
                _maxSpawnerWeight = 0;
            }
        }

        public void Initialize()
        {
            _enemyVisitor = new EnemyVisitor();
            StartSpawn();
        }

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
            while (_enemyVisitor.Weight < _maxSpawnerWeight)
            {
                var enemy = _enemyFactory.Spawn((EnemyType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.AcceptVisit(_enemyVisitor);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
        private class EnemyVisitor : IEnemyVisitor
        {
            private float _humanWeight = 10;
            private float _orkWeight = 20;
            private float _elfWeight = 5;

            public float Weight { get; private set; }

            public void Visit(Ork ork)
            {
                TryAddWeight(_orkWeight);
            }

            public void Visit(Elf elf)
            {
                TryAddWeight(_elfWeight);
            }

            public void Visit(Human human)
            {
                TryAddWeight(_humanWeight);
            }

            private bool TryAddWeight(float weight)
            {
                if (weight < 0)
                    throw new ArgumentException(nameof(_orkWeight));

                Debug.Log($"Add {weight}");
                Weight += weight;

                return true;
            }
        }
    }
}
