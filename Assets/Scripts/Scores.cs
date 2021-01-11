using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    // Update is called once per frame
    public Transform player;
    public Text scoreText;
    void Update()
    {
        if(player.position.z <= 857){
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
