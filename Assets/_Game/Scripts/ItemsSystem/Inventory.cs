using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private GameObject _gameObject;
        [SerializeField] private Transform _itemPosition;
        
        private Item _item;

        private bool _useInput;
        
        public void SetInput(bool useInput)
        {
            _useInput = useInput;
        }

        public bool TrySetItem(Item item)
        {
            if(item == _item || _item != null)
                return false;
            
            _item = item;

            SetPositionItem();
            
            return true;
        }

        private void SetPositionItem()
        {
            _item.gameObject.transform.SetParent(_itemPosition);
            _item.gameObject.transform.localPosition = Vector3.zero;
        }

        private void Update()
        {
            if (_useInput)
            {
                UseItem();
            }
        }

        private void UseItem()
        {
            if (_item == null)
            {
                Debug.Log("You don't have item");
                return;
            }

            _item.Use(_gameObject);
            _item.Destroy();
            
            _item = null;
        }
        
    }
}
