using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimeinto : MonoBehaviour
{
    public float velocidad = 10;
    public float velRotacion = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime * Input.GetAxis("Vertical") * Vector3.forward);
        transform.Rotate(velRotacion * Time.deltaTime * Input.GetAxis("Horizontal") * Vector3.up);
    }
}
