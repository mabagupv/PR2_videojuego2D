using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{

    GameObject spawn;


    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            col.gameObject.transform.position = spawn.transform.position;
            GameManager.vida = GameManager.vida-1;
        }
    }



}
