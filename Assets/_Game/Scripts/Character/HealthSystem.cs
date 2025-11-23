using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(HealthChanger))]
    public class HealthSystem : MonoBehaviour
    {
        
        [SerializeField] private int _baseMaxHealth;
        
        private HealthChanger _healthChanger;
        public bool IsAlive => _healthChanger.Health > 0;

        private void Awake()
        {
            _healthChanger = GetComponent<HealthChanger>();
            _healthChanger.Initialize(_baseMaxHealth);
            
            _healthChanger.TakeDamage(4);// for test
        }
    }
}