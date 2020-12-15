using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacingRespawn : MonoBehaviour{


    public float minX;

    public float maxX;

    public float minY;

    public float maxY;

    void OnCollisionEnter2D(Collision2D col){
        if(col.transform.CompareTag("CACING"))
        {
            ScoreScript.scoreValue += 10;
            SwicthCharacter.scoreValue += 10;
            col.transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        }
    }

}
