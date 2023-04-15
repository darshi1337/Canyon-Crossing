using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManeger : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    private void Awake(){
        isGameOver = false;
    }
    
    void Update()
    {
        if(isGameOver){
            gameOverScreen.SetActive(true);
        }
    }
}
