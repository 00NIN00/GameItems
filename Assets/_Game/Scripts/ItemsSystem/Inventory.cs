using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    [RequireComponent(typeof(Data))]
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private Data _data;
        [SerializeField] private Transform _itemPosition;
        
        private Item _item;

        private bool _useInput;

        private void Awake()
        {
            _data = GetComponent<Data>();
        }

        public void SetInput(bool useInput)
        {
            _useInput = useInput;
        }

        public void SetItem(Item item)
        {
            if(item == _item || _item != null)
                return;
            
            _item = item;

            SetPositionItem();
        }

        private void SetPositionItem()
        {
            _item.gameObject.transform.SetParent(_itemPosition);
            _item.gameObject.transform.localPosition = Vector3.zero;
        }

        private void Update()
        {
            if (_item != null && _useInput)
            {
                UseItem();
            }
        }

        private void UseItem()
        {
            _item.Use(_data);
            _item.Destroy();
            
            _item = null;
        }
        
    }
}
