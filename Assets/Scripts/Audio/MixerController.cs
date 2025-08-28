using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    public AudioMixer miAudioMixer;

    public string NombreParametro;
    public void EnviarValorSlider(float valorSlider)
    {
        miAudioMixer.SetFloat(NombreParametro,  valorSlider);
    }

    public void CambiarParametroLog(float valorSlider)
    {
        float valorLog = Mathf.Log10(valorSlider) * 20;

        if (valorSlider == 0)
        {
            miAudioMixer.SetFloat(NombreParametro, -80f);

        }
        else
        {
            miAudioMixer.SetFloat(NombreParametro, valorLog);
        }
    }
}
