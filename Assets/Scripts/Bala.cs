using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 1;

    public int potenciaArma = 1;
    GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if(player.GetComponent<Movimiento>().direccionBalaDcha == true){
            velocidad = velocidad*1;
        }

        if(player.GetComponent<Movimiento>().direccionBalaDcha == false){
            velocidad = velocidad*-1;
        }


    }

    // Update is called once per frame
    void Update()
    {

        float velocidadFinal = velocidad * Time.deltaTime;
        transform.Translate(velocidadFinal, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
       if(col.gameObject.name.StartsWith("enemigo_fantasma")){
          Destroy(this.gameObject);
            //fastasma
            col.gameObject.GetComponent<FantasmaScript>().vidaFantasma -= potenciaArma;
       }


    }



}
