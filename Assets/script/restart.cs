using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    public GameObject GOPanel;


    // Start is called before the first frame update
    void Start()
    {
        GOPanel.SetActive(true);
    }

    public void UpdateScore(){
        ScoreScript.scoreValue = 0;
        SwicthCharacter.scoreValue = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
