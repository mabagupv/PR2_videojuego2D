using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;
    GameObject camera;
    public float velocidadParallax = 1;

    private Vector3 positionInicial;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        camera = GameObject.FindWithTag("MainCamera");
        positionInicial = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(camera.transform.position.x * velocidadParallax, 0, 0);
        //transform.position = positionInicial+camera.transform.position;
        
        /*transform.position = new Vector3(
            positionInicial.x+(camera.transform.position.x*velocidadParallax), 
            , 0);
        */
        transform.position = new Vector3(
            positionInicial.x+(camera.transform.position.x*velocidadParallax),//X
            positionInicial.y+(camera.transform.position.y*velocidadParallax),//Y
            0//Z
        );
    }






}
