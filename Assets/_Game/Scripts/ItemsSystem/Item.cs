using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public abstract class Item : MonoBehaviour
    {
        public abstract void Use(Data data);

        public void PickUp()
        {
            GetComponentInChildren<AnimateRotation>().enabled = false;
        }
        public void Destroy()
        {
            Destroy(gameObject);
        }
    }
}