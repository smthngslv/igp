using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;

    private int _directionIndex;
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnDisable()
    {
        var velocity = Vector3.zero;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _directionIndex = (_directionIndex + 1) % 2;
        }
    }

    private void FixedUpdate()
    {
        var velocity = (_directionIndex == 0 ? Vector3.forward : Vector3.right) * speed;
        velocity.y = _rigidbody.velocity.y;
        _rigidbody.velocity = velocity;
    }
}
