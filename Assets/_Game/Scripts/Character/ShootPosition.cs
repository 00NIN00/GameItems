using UnityEngine;

namespace _Game.Scripts
{
    public class ShootPosition : MonoBehaviour
    {
        [field:SerializeField] public Transform Position { get; private set; }
    }
}