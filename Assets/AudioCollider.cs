using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollider : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_AudioSource;
   
        void Start()
    {   
        m_AudioSource.Play();
        Debug.Log("playAudioStart");
    }

    void OnTriggerEnter(Collider other)
    {
            m_AudioSource.Pause();
        Debug.Log("Pause");
    }

    void OnTriggerExit(Collider other)
    {
            m_AudioSource.UnPause();
        Debug.Log("Unpause");
    }


}
