using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public GameObject obj;
    public Color color;
    
    // asigna un color aleatorio al GameObject cada vez que se pulsa el boton
    public void buttonPressed()
    {
        color = new Color(Random.Range(0F,1F), Random.Range(0, 1F), Random.Range(0, 1F));
        obj.GetComponent<Renderer>().material.color = color;
    }

}
