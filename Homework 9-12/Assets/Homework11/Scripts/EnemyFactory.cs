using System;
using UnityEngine;

namespace Assets.Homework11.Scripts
{
    [CreateAssetMenu(menuName = "Factory/EnemyFactory")]
    public class EnemyFactory : ScriptableObject
    {
        [SerializeField] private Ork _ork;
        [SerializeField] private Human _human;
        [SerializeField] private Elf _elf;

        public Enemy Spawn(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Human: return _human;
                case EnemyType.Elf: return _elf;
                case EnemyType.Ork: return _ork;
                default: throw new ArgumentException(nameof(enemyType));
            }
        }
    }
}
