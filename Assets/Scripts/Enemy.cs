using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Transform _target;
    
    private void Update()
    {
        Move();
    }

    public void SetPosition(Transform target)
    {
        _target = target;
    }
    
    private void Move()
    {
        Vector3 currentPosition = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        
        currentPosition.y = transform.position.y;
        transform.position = currentPosition;
    }
}