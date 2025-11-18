using UnityEngine;

public class AnimateRotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    
    [Header("Настройки покачивания")]
    [SerializeField] private float _amplitude = 0.5f;
    [SerializeField] private float _frequency = 1f;  
    
    private Vector3 _startPosition;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        Rotate();
        MoveSin();
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0, -1, 0) * (_rotateSpeed * Time.deltaTime));   
    }

    private void MoveSin()
    {
        float newY = _startPosition.y + Mathf.Sin(Time.time * _frequency) * _amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
