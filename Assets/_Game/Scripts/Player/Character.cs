using UnityEngine;

namespace _Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(Data))]
    public class Character : MonoBehaviour
    {
        private Vector3 _input;
        
        private Data _data;
        private float _speed => _data.Speed;
        [SerializeField] private float _rotationSpeed;
        
        private MovementCharacter _movementCharacter;
        private RotationCharacter _rotationCharacter;

        private void Awake()
        {
            _data = GetComponent<Data>();
            
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
            _movementCharacter.MoveTo(_input, _speed);
        }

        private void Rotate()
        {
            _rotationCharacter.RotateTo(_input, _rotationSpeed);
        }
    }
}