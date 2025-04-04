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
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
