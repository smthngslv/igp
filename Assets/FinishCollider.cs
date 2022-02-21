using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var playerMovement = other.GetComponent<PlayerMovement>();
        
        if (other.GetComponent<PlayerMovement>() is not null)
        {
            playerMovement.enabled = false;
            Debug.Log("Finish!");
        }
    }
}
