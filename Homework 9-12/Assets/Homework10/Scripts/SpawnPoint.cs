using UnityEngine;

namespace Assets.Homework10.Scripts
{
    public class SpawnPoint : MonoBehaviour
    {
        private bool _isBusy;

        [Header("Gizmos")]
        [SerializeField] private bool _enableDrawGizmos = true;
        [SerializeField, Range(0, 5)] private float _gizmosSphereRadius = 0.5f;

        public bool IsBusy => _isBusy;

        public bool CheckForBusy()
        {
            var coin = GetComponentInChildren<Coin>();
            if (coin == null) return false;
            return _isBusy = true;
        }

        private void OnDrawGizmos()
        {
            if (_enableDrawGizmos == false) return;
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, _gizmosSphereRadius);
        }
    }
}
