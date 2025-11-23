using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(HealthSystem))]
    public class HealthChanger : MonoBehaviour
    {
        private float _health;

        private int _maxHealth;
        
        public float Health => _health;
        public int MaxHealth => _maxHealth;

        public void Initialize(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }
        
        public void TakeDamage(float damage)
        {
            if (damage < 0)
                return;

            _health -= damage;

            if (_health <= 0)
            {
                _health = 0;
            }
            
            Debug.Log("Taking damage!" + "health = "+_health);
        }

        public void AddHealth(float heal)
        {
            if (heal < 0)
                return;
        
            _health += heal;

            if (_health > _maxHealth)
            {
                _health = _maxHealth;
            }
            
            Debug.Log("Add Health!" + "health = "+_health);
        }
    }
}