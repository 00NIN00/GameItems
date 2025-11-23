using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public class ItemShoot : Item
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private float _bulletLiveTime;
        
        [SerializeField] private float _bulletForce;
        
        public override void Use(GameObject gameObject)
        {
            base.Use(gameObject);

            if (CanUse(gameObject) != true)
                return;

            Transform shootPosition = gameObject.GetComponent<ShootPosition>().Position;
            
            Bullet bullet = Instantiate(_bulletPrefab,shootPosition.position, shootPosition.rotation);
            bullet.Launch(_bulletForce, shootPosition.forward);
            
            Destroy(bullet.gameObject, _bulletLiveTime);
        }
        
        public override bool CanUse(GameObject gameObject)
        {
            return gameObject.GetComponent<ShootPosition>();
        }
    }
}