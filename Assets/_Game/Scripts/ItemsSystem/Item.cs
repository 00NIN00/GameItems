using UnityEngine;

namespace _Game.Scripts.ItemsSystem
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particlePrefab;
        public virtual void Use(GameObject gameObject)
        {
            ParticleSystem particleSystem = Instantiate(_particlePrefab, transform.position, Quaternion.identity);
            particleSystem.Play();
        }

        public abstract bool CanUse(GameObject gameObject);

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