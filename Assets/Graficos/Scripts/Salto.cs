using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    public int miEdad = 50;
    public float miAltura = 4.1f;
    public string miNombre = "Mañiaño o'Doherty";
    public bool tengoMelena = false;

  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    
    void Update()
    {
         Debug.Log("Y tengo "+miEdad+" años." );
    }
    

}
