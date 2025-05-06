using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int vida = 10;
    public static int marcador = 0;
    public static bool estoyVivo = true;

    private GameObject vidasText;

    // Start is called before the first frame update
    void Start()
    {
        vidasText = GameObject.Find("TextoVidas");
    }

    // Update is called once per frame
    void Update()
    {

        if( vida <= 0){
            estoyVivo = false;
       
        }

        vidasText.GetComponent<TextMeshProUGUI>().text = vida.ToString();

        //Debug.Log("Monedas: "+ marcador);



    }


}
