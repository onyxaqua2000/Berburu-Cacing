using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausecript : MonoBehaviour
{

    public GameObject GOPanel;
    public GameObject GOPanel2;

    bool isPaused = false;

    // Start is called before the first frame update
    public void pauseGame(){
        if (isPaused) {
            Time.timeScale = 1;
            isPaused = false;
        } else {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
    public void tampilkanpause(){
        GOPanel.SetActive(true);
        GOPanel2.SetActive(false);
    }
}
