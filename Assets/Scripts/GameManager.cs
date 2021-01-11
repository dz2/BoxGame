using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    // Start is called before the first frame update
    public GameObject completeLevelUI;
    public GameObject continueLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }


    public void EndGame () 
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            continueLevelUI.SetActive(true);
            
        }
        
    }

    public void Restart () 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
