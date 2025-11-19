using System.Collections.Generic;
using _Game.Scripts.ItemsSystem;
using UnityEngine;

namespace _Game.Scripts.SpawSystem
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Item[] _items;
        
        [SerializeField] private int _cooldown;

        private float _timer;
        private List<SpawnPoint> _spawnPoints = new List<SpawnPoint>();

        private void Awake()
        {
            SearchSpawnPoints();
        }

        private void SearchSpawnPoints()
        {
            Debug.Log(transform.childCount);
            
            for (int i = 0; i < transform.childCount; i++)
            {
                _spawnPoints.Add(transform.GetChild(i).GetComponent<SpawnPoint>());
            }
        }

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= _cooldown)
            {
                Spawn();
                
                _timer = 0;
            }
        }

        private void Spawn()
        {
            List<SpawnPoint> emptySpawnPoints = GetEmptySpawnPoints();

            if (emptySpawnPoints.Count == 0)
            {
                _timer = 0;
                return;
            }
                
            SpawnPoint spawnPoint = emptySpawnPoints[Random.Range(0, emptySpawnPoints.Count)];
                
            Item item = Instantiate(_items[Random.Range(0, _items.Length)], spawnPoint.Position, Quaternion.identity);
                
            spawnPoint.Occupy(item);
        }

        private List<SpawnPoint> GetEmptySpawnPoints()
        {
            List<SpawnPoint> emptyPoints = new List<SpawnPoint>();

            foreach (SpawnPoint point in _spawnPoints)
            {
                if (point.IsEmpty)
                    emptyPoints.Add(point);
            }
            
            return emptyPoints;
        }
    }
}
