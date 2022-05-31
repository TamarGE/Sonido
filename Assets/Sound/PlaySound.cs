using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;

    AudioSource fuenteSonido;

    void Start()
    {
        fuenteSonido = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            fuenteSonido.clip = sound1;
            fuenteSonido.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            fuenteSonido.clip = sound2;
            fuenteSonido.Play();
        }
    }
}
