using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanjutkanscript : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject GOPanel2;

    bool isPaused = true;

    // Start is called before the first frame update
    public void pauseGame(){
        if (isPaused) {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
    public void tampilkanpause(){
        GOPanel.SetActive(true);
        GOPanel2.SetActive(false);
    }
}
