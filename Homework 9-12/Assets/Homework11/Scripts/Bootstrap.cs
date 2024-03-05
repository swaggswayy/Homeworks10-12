using UnityEngine;

namespace Assets.Homework11.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        private void Awake() 
        {
            _spawner.Initialize();
        }
    }
}
