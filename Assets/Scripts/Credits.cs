﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToMenu () 
    {
        SceneManager.LoadScene(0);
    }
}
