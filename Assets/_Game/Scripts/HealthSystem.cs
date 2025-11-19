using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(HealthData))]
    public class HealthSystem : MonoBehaviour
    {
        
        [SerializeField] private int _baseMaxHealth;
        
        private HealthData _healthData;
        public bool IsAlive => _healthData.Health > 0;

        private void Awake()
        {
            _healthData = GetComponent<HealthData>();
            _healthData.Initialize(_baseMaxHealth);
            
            _healthData.TakeDamage(4);// for test
        }
    }
}