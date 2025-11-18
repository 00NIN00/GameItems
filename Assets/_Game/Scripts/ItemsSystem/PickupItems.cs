using System;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class PickupItems : MonoBehaviour
    {
        private Inventory _inventory;

        private void Awake()
        {
            if (transform.parent.TryGetComponent(out Inventory inventory))
                _inventory = inventory;
            else
                Debug.LogError("Inventory component not found");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Item item))
            {
                _inventory.SetItem(item);
                item.PickUp();
            }
        }
    }
}