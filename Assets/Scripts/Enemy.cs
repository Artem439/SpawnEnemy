using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Renderer _renderer;
    
    private protected Vector3 _targetPosition;
    
    private void Update()
    {
        Move();
    }

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void Initialize(Vector3 targetPosition, Material material)
    {
        _targetPosition = targetPosition;
        _renderer.material = material;
    }
    
    private protected void Move()
    {
        Vector3 currentPosition = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        
        currentPosition.y = transform.position.y;
        transform.position =  currentPosition;
    }
}