using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerDeath : MonoBehaviour{

    public GameObject menuContainer;
    public GameObject menuContainer2;
    public GameObject audiog;
    public void OnCollisionEnter2D(Collision2D col){
        if(col.transform.CompareTag("Enemy")){
            Destroy(gameObject);
            menuContainer.SetActive(true);
            menuContainer2.SetActive(false);
            audiog.SetActive(false);
        }
    }

}
