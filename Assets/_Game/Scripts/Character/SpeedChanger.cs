using UnityEngine;

namespace _Game.Scripts
{
    public class SpeedChanger : MonoBehaviour
    {
        private float _speed;

        public float Speed => _speed;

        public void Initialize(float speed)
        {
            _speed = speed;
        }
        
        public void AddSpeed(float multiplier)
        {
            if (multiplier < 1)
                return;
            
            _speed *= multiplier;
        }
    }
}