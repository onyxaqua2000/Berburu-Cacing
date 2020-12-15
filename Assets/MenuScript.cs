using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject GOPanel2;


    // Start is called before the first frame update

    void Start()
    {
        GOPanel.SetActive(true);
    }

    public void UpdateScore(){
        ScoreScript.scoreValue = 0;
    }

    public void MenuClick(){
        GOPanel.SetActive(false);
        GOPanel2.SetActive(true);
    }
}
