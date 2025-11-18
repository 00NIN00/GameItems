using _Game.Scripts.Player;
using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class ItemAddSpeed : Item
    {
        [SerializeField] private float _multiplier;

        public override void Use(Data data)
        {
            data.Speed *= _multiplier;
        }
    }
}