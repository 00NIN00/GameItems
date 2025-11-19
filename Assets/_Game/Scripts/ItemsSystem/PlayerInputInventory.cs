using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    [RequireComponent(typeof(Inventory))]
    
    public class PlayerInputInventory : MonoBehaviour
    {
        private const KeyCode UseItemKey = KeyCode.F;

        private Inventory _inventory;
        private void Awake()
        {
            _inventory = GetComponent<Inventory>();
        }

        private void Update()
        {
            _inventory.SetInput(GetKeyUseItemInput());
        }
        
        private bool GetKeyUseItemInput()
        {
            return Input.GetKeyDown(UseItemKey);
        }
    }
}