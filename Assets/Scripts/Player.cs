using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public Text gameOverText;
    public Text WINTEXT;

    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.tag == "Win"){
            WINTEXT.gameObject.SetActive(true);
            AudioManager.instance.Play("WIN");
        }

        if(collision.tag == "Enemy"){
            gameOverText.gameObject.SetActive(true);
            AudioManager.instance.Play("GameOver");
            Time.timeScale = 0;
        }
    }
}