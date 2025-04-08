using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    public int vidaFantasma = 10;
    public float velocidad = 1;

    public float limiteDerecha = 5;
    public float limiteIzquierda = 5;

    private Vector3 posLimitDcha;
    private Vector3 posLimitIzda;

    private bool dirFantasmaDerecha = true;
    private Vector3 posInicial;

    private string estadoFantasma = "Patrol";

    private GameObject player;

    private float distancia;
    public float distanciaAtaque = 5;
    public float distanciaPatrol = 15;

    public float velocidadAtaque = 2;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        posLimitDcha = new Vector3(posInicial.x + limiteDerecha, posInicial.y, 0);
        posLimitIzda = new Vector3(posInicial.x - limiteIzquierda, posInicial.y, 0);
        this.GetComponent<SpriteRenderer>().flipX = true;

        player = GameObject.FindWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        if (vidaFantasma <= 0)
        {
            Destroy(this.gameObject);
        }

        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= distanciaAtaque)
        {
            estadoFantasma = "Ataque";
        }

        if(distancia >= distanciaPatrol){
            estadoFantasma = "Patrol"; 
        }

        //////////////////
        ////PATROL
        //////////////////
        if (estadoFantasma == "Patrol")
        {
            //estmos flotando hacia la derecha
            if (dirFantasmaDerecha == true)
            {
                transform.Translate(velocidad * Time.deltaTime, 0, 0);
            }

            //estmos flotando hacia la derecha
            if (dirFantasmaDerecha == false)
            {
                transform.Translate((velocidad * Time.deltaTime) * -1, 0, 0);
            }

            //comprobar si nos hemos salido del límite derecho
            if (transform.position.x >= posLimitDcha.x)
            {
                dirFantasmaDerecha = false;
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

            //comprobar si nos hemos salido del límite izquierdo
            if (transform.position.x <= posLimitIzda.x)
            {
                dirFantasmaDerecha = true;
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
        }


        //////////////////
        ////ATAQue
        //////////////////
        if(estadoFantasma == "Ataque"){
            transform.position = Vector3.MoveTowards(
                transform.position, player.transform.position, velocidadAtaque*Time.deltaTime
            );

            if(player.transform.position.x <= transform.position.x){
                this.GetComponent<SpriteRenderer>().flipX = false;
            }else{
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        //Debug.Log(distancia + "****" + estadoFantasma);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            GameManager.vida -= 1;
        }
    }

}
