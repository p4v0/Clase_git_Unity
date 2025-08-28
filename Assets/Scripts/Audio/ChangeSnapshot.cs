using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangeSnapshot : MonoBehaviour
{
    public AudioMixerSnapshot miSnapshot;
    

    public int tiempoDeTransicion = 1;


    public void StartSnapshot()
    {
        miSnapshot.TransitionTo(tiempoDeTransicion);
    }

    
}
