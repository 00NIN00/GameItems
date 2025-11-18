using UnityEngine;

namespace _Game.Scripts.Player
{
    public class RotationCharacter
    {
        private const float DeadZone = 0.1f;
        private Transform _transform;

        public RotationCharacter(Transform transform)
        {
            _transform = transform;
        }
        
        public void RotateTo(Vector3 direction, float rotationSpeed)
        {
            if (direction.magnitude <= DeadZone)
                return;
            
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            float step = rotationSpeed * Time.deltaTime;
            _transform.rotation = Quaternion.RotateTowards(_transform.rotation, lookRotation, step);
        }
    }
}
