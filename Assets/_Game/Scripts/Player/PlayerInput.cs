using UnityEngine;

namespace _Game.Scripts.Player
{
    [RequireComponent(typeof(Character))]
    public class PlayerInput : MonoBehaviour
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        
        private Character  _character;

        private void Awake()
        {
            _character = GetComponent<Character>();
        }

        private void Update()
        {
            _character.SetInput(GetInput());
        }

        private Vector3 GetInput()
        {
            return new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));
        }
    }
}