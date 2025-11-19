using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class ItemAddSpeed : Item
    {
        [SerializeField] private float _multiplier;

        public override void Use(GameObject gameObject)
        {
            if (CanUse(gameObject))
            {
                gameObject.GetComponent<SpeedData>().AddSpeed(_multiplier);
            }
            
            base.Use(gameObject);
        }

        public override bool CanUse(GameObject gameObject)
        {
            return gameObject.GetComponent<SpeedData>();
        }
    }
}