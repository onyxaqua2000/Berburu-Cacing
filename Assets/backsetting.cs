using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsetting : MonoBehaviour
{
    public GameObject a1, a2, a3, a4, a5, a6, a7;


    public void Start(){
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    public void click(){
        a1.SetActive(true);
        a2.SetActive(true);
        a3.SetActive(true);
        a4.SetActive(true);
        a5.SetActive(true);
        a6.SetActive(false);
        a7.SetActive(false);
    }
}
