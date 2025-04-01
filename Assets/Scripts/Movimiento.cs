using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //velocidad = 1
        //movTeclas = 1/-1
        //Time.deltatime = ? 0.0001
        float MovTeclas = Input.GetAxis("Horizontal");
        
        float velocidadFinal = (velocidad * MovTeclas) * Time.deltaTime;

        transform.Translate(velocidadFinal, 0f, 0f);

        Debug.Log(MovTeclas);

    }
}
