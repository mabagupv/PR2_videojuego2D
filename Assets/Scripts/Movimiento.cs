using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad = 1;
    public bool direccionBalaDcha = true;

    // Start is called before the first frame update
    void Start()
    {
        MensajeConRetardo();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(this.name);


        if(GameManager.estoyVivo == false){
            return;
        }

        //velocidad = 1
        //movTeclas = 1/-1
        //Time.deltatime = ? 0.0001
        float MovTeclas = Input.GetAxis("Horizontal");

        //Flip personaje Derecha
        if(MovTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
            this.GetComponent<Animator>().SetBool("activaCamina", true);
            direccionBalaDcha = true;
        }
        //Flip personaje izquierda
        if(MovTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
            this.GetComponent<Animator>().SetBool("activaCamina", true);
            direccionBalaDcha = false;
        }

        if(MovTeclas == 0){
            this.GetComponent<Animator>().SetBool("activaCamina", false);
        }

        
        float velocidadFinal = (velocidad * MovTeclas) * Time.deltaTime;

        transform.Translate(velocidadFinal, 0f, 0f);

        //Debug.Log(MovTeclas);

    }


    async void MensajeConRetardo()
    {
        Debug.Log("Esperando 3 segundos...");
        await Awaitable.WaitForSecondsAsync(3f);
        Debug.Log("¡Han pasado 3 segundos!");
        await Awaitable.WaitForSecondsAsync(2f);
        Debug.Log("¡Han pasado 5 segundos!");
    }



}
