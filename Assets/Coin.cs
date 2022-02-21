using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 5;
    public float moveSpeed = 2;
    public float moveAmplitude = 0.7f;

    private float _initialY;

    private void Awake()
    {
        _initialY = transform.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        var playerMovement = other.GetComponent<PlayerMovement>();
        
        if (playerMovement is not null)
        {
            Destroy(gameObject);
            playerMovement.IncrementScore();
            Debug.Log($"Score: {playerMovement.Score}");
        }
    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);

        var position = transform.position;
        position.y = _initialY + ((float) Math.Sin(Time.time * moveSpeed) + 1) * moveAmplitude;
        transform.position = position;
    }
}
