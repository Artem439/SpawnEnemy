using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private NonPlayerCharacter _target;
    
    private void Update()
    {
        Move();
    }

    public void SetTarget(NonPlayerCharacter target)
    {
        _target = target;
    }
    
    private void Move()
    {
        Vector3 currentPosition = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        
        currentPosition.y = transform.position.y;
        transform.position = currentPosition;
    }
}