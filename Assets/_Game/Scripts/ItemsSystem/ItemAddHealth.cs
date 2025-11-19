using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class ItemAddHealth : Item
    {
        [SerializeField] private int _health;
        public override void Use(GameObject gameObject)
        {
            if (CanUse(gameObject) != true)
                return;

            gameObject.GetComponent<HealthData>().AddHealth(_health);
            
            base.Use(gameObject);
        }

        public override bool CanUse(GameObject gameObject)
        {
            return gameObject.TryGetComponent(out HealthData _);
        }
    }
}