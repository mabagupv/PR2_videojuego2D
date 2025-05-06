using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{

    public AudioSource m_audioSource;
    public AudioClip bandaSonora;
    public AudioClip moneda;
    public AudioClip sFantasma;

    public static AudioManagerScript Instance;

    void Awake(){

        if(Instance != null && Instance != this){
            Destroy(this.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.clip = bandaSonora;
        //m_audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
   
    }


    public void SuenaMoneda(){
        m_audioSource.PlayOneShot(moneda);
    }
    
    public void SuenaMoadfneda(){
        m_audioSource.PlayOneShot(moneda);
    }
    
    //Método para hacer sonar clips de audio
    public void SuenaClip(AudioClip miClipDeAudio){
        m_audioSource.PlayOneShot(miClipDeAudio);
    }


}
