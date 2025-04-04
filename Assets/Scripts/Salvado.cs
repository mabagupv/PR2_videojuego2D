using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvado : MonoBehaviour
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

    void OnTriggerExit2D(Collider2D collision)
    {
        spawn.transform.position = transform.position;
        GameManager.vida = GameManager.vida+1; 
    }

    
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            spawn.transform.position = transform.position;
            GameManager.vida = GameManager.vida+1;
        }
    }
*/


}
