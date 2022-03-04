using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollbar : MonoBehaviour
{
    // multiplicador de tamaño
    public float mult = 10;

    // multiplica el tamaño del objeto por mult y por el valor del Scrollbar
    public void Resize(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * mult * Vector3.one;
    }

}
