﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    public GameObject GOPanel;
    public GameObject GOPanel2;
    public GameObject GOPanel3;
    public GameObject GOPanel4;
    public GameObject GOPanel5;
    public GameObject GOPanel6;
    public GameObject GOPanel7;
    public GameObject GOPanel8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void keluarcarabermain(){
        GOPanel.SetActive(false);
        GOPanel2.SetActive(false);
        GOPanel3.SetActive(false);
        GOPanel4.SetActive(false);
        GOPanel5.SetActive(true);
        GOPanel6.SetActive(true);
        GOPanel7.SetActive(true);
        GOPanel8.SetActive(true);
    }

    public void next1(){
        GOPanel.SetActive(false);
        GOPanel2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
