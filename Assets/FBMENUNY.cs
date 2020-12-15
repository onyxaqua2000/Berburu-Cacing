using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FBMENUNY : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject GOPanel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void clickn(){
        GOPanel.SetActive(true);
        GOPanel2.SetActive(false);
    }

    // Update is called once per frame

    public void clicky(){
        SceneManager.LoadScene(0);
    }

    public void UpdateScore(){
        ScoreScript.scoreValue = 0;
        SwicthCharacter.scoreValue = 0;
    }

    void Update()
    {
        
    }
}
