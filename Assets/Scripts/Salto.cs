using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Salto : MonoBehaviour
{

    public float velocidad = 1.0f;
  
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        transform.Translate(velocidad,0,0);
        //transform.Rotate(0,0,velocidad);
        //transform.localScale = new Vector3(velocidad, 1.0f, 1.0f);

        //Ir a la izquierdas
        /*
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(velocidad*-1,0,0);
        }


        if(Input.GetKey(KeyCode.D)){
            transform.Translate(velocidad, 0 , 0);
        }

*/

    }


    

}
