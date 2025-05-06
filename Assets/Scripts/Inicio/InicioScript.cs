using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{

    GameObject panelSettings;
    GameObject audioManagerObj;
    AudioManagerScript audioManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.Find("Settings");
        panelSettings.SetActive(false);

        audioManagerObj = GameObject.Find("AudioManagerObj");
        audioManagerScript = audioManagerObj.GetComponent<AudioManagerScript>();
         

    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    public void InicioStart(){
        SceneManager.LoadScene("Escena1");
    } 

    public void MuestraSettings(){
        panelSettings.SetActive(true);
    }
    public void OcultarSettings(){
        panelSettings.SetActive(false);
    }


    public void SuenaBoton(){
        audioManagerScript.m_audioSource.PlayOneShot(audioManagerScript.moneda);
    }


    public void SalirJuego(){
        Application.Quit();
    }    





}
