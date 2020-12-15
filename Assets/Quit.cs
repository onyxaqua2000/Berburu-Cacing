using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject GOPanel2;
    public GameObject GOPanel3;
    public GameObject GOPanel4;
    public GameObject GOPanel5;
    public GameObject GOPanel6;
    public GameObject GOPanel7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void keluar(){
        GOPanel.SetActive(true);
        GOPanel2.SetActive(true);
        GOPanel3.SetActive(false);
        GOPanel4.SetActive(false);
        GOPanel5.SetActive(false);
        GOPanel6.SetActive(false);
        GOPanel7.SetActive(false);
    }

    public void gajadikeluar(){
        GOPanel.SetActive(false);
        GOPanel2.SetActive(true);
        GOPanel3.SetActive(true);
        GOPanel4.SetActive(true);
        GOPanel5.SetActive(true);
    }

    public void keluarsudah(){
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
