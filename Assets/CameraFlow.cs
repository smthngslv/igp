using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform follow;

    private Vector3 _offset;
    private float _initialY;

    private void Awake()
    {
        var position = transform.position;
        _offset = position - _offset;
        _initialY = position.y;
    }

    private void LateUpdate()
    {
        var position = follow.position + _offset;
        position.y = _initialY;
        transform.position = position;
    }
}
