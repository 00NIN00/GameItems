using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float _force;
        public void Launch(float force, Vector3 direction)
        {
            _rigidbody = GetComponent<Rigidbody>();
            
            _rigidbody.AddForce(direction * force, ForceMode.Impulse);
        }
    }
}