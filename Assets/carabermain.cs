﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carabermain : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject GOPanel2;
    public GameObject GOPanel3;
    public GameObject GOPanel4;
    public GameObject GOPanel5;
    public GameObject GOPanel6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void click(){
        GOPanel.SetActive(true);
        GOPanel2.SetActive(true);
        GOPanel3.SetActive(false);
        GOPanel4.SetActive(false);
        GOPanel5.SetActive(false);
        GOPanel6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
