using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement movement;
    public GameManager gameManager;
    private void OnTriggerEnter() 
    {
        movement.enabled = false;
        gameManager.CompleteLevel();
    }
}
