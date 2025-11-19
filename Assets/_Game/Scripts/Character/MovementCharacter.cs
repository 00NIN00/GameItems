using UnityEngine;

namespace _Game.Scripts.Player
{
    public class MovementCharacter
    {
        private CharacterController _characterController;

        public MovementCharacter(CharacterController characterController)
        {
            _characterController = characterController;
        }

        public void MoveTo(Vector3 input, float speed)
        {
            _characterController.Move(input.normalized * (speed * Time.deltaTime));
        }
    }
}