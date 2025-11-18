using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(Data))]
    public class HealthSystem : MonoBehaviour
    {
        private Data _data;

        public float Health => _data.Health;
        public float MaxHealth => _data.MaxHealth;

        public bool IsAlive => Health > 0;

        private void Awake()
        {
            _data = GetComponent<Data>();
        
            _data.Health = MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0)
                return;

            _data.Health -= damage;

            if (_data.Health <= 0)
            {
                _data.Health = 0;
            }
        }

        public void AddHealth(float heal)
        {
            if (heal < 0)
                return;
        
            _data.Health += heal;

            if (Health > MaxHealth)
            {
                _data.Health = MaxHealth;
            }
        }
    }
}