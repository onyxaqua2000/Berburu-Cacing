using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatar2 : MonoBehaviour
{

    public GameObject cacing1, cacing2;
    // Start is called before the first frame update
    void update(){
        if(ScoreScript.scoreValue >= 5){
            cacing1.SetActive(true);
            cacing2.SetActive(false);
        }
        return;
    }
}
