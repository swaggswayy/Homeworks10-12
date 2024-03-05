using UnityEngine;

namespace Assets.Homework11.Scripts
{
    public abstract class Enemy : MonoBehaviour
    {
        public abstract void AcceptVisit(IEnemyVisitor visitor);
    }
}
