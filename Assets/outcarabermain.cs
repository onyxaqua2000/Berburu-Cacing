using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outcarabermain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GOPanel;
    public GameObject GOPanel2;
    public GameObject GOPanel3;
    public GameObject GOPanel4;
    public GameObject GOPanel5;
    public GameObject GOPanel6;
    public GameObject GOPanel7;
    public GameObject GOPanel8;
    public GameObject GOPanel9;

    public GameObject ab, abtombol;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void keluarcarabermain(){
        ab.SetActive(false);
        abtombol.SetActive(true);
        GOPanel.SetActive(false);
        GOPanel2.SetActive(false);
        GOPanel3.SetActive(false);
        GOPanel4.SetActive(false);
        GOPanel5.SetActive(false);
        GOPanel6.SetActive(true);
        GOPanel7.SetActive(true);
        GOPanel8.SetActive(true);
        GOPanel9.SetActive(true);
    }
}