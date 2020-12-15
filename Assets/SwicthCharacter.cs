using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwicthCharacter : MonoBehaviour
{
    public static int scoreValue = 0;
    public GameObject petani, audiok, audiog;

    public Rigidbody2D myRB;
    public Animator myAnim;


    // Start is called before the first frame update
    public void Start()
    {
        myAnim = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
        petani.SetActive(false);
    }

    public void Update(){
        if (scoreValue >= 100){
            myAnim.Play("transform 0");
            petani.SetActive(true);
            audiog.SetActive(true);
            audiok.SetActive(false);
            this.enabled = false;
        }
    }

    // Update is called once per frame
    //public void Update()
    //{
        //if(scoreValue >= 100){
            //avatar1.SetActive (false);
            //avatar2.SetActive (true);
            //camera1.SetActive (true);
            //camera2.SetActive(false);
            //petani.SetActive(true);
        //}
    //}
}