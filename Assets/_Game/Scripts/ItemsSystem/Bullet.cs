using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float _force;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            
            _rigidbody.AddForce(transform.forward * _force, ForceMode.Impulse);
        }
    }
}