using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//esto tmambioen es un cambio



public class Spawn : MonoBehaviour
{
    GameObject spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Spawner");
        transform.position = spawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {                                                                                           
        //spawnear si caigo al vacío
        if(transform.position.y <= -10){
            transform.position = spawn.transform.position;
        }
    }

/*
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        if(col.gameObject.name.StartsWith("Spikes")){
            //quitar vida
            transform.position = spawn.transform.position;

        }
    }
*/

}
