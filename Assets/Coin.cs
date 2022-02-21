using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var playerMovement = other.GetComponent<PlayerMovement>();
        
        if (playerMovement is not null)
        {
            Destroy(gameObject);
            Debug.Log("Coin destroyed!");
        }
    }
}
