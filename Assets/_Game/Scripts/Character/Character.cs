using UnityEngine;

namespace _Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(SpeedChanger))]
    public class Character : MonoBehaviour
    {
        private Vector3 _input;
        
        [SerializeField] private float _baseSpeed;
        private SpeedChanger _speedChanger;
        
        [SerializeField] private float _rotationSpeed;
        
        private MovementCharacter _movementCharacter;
        private RotationCharacter _rotationCharacter;

        private void Awake()
        {
            _speedChanger = GetComponent<SpeedChanger>();
            _speedChanger.Initialize(_baseSpeed);
            
            _movementCharacter = new MovementCharacter(GetComponent<CharacterController>());
            _rotationCharacter = new RotationCharacter(transform);
        }

        public void SetInput(Vector3 input)
        {
            _input = input;
        }
        
        private void Update()
        {
            Move();
            Rotate();
        }

        private void Move()
        {
            _movementCharacter.MoveTo(_input, _speedChanger.Speed);
        }

        private void Rotate()
        {
            _rotationCharacter.RotateTo(_input, _rotationSpeed);
        }
    }
}