using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    // cambia la posicion en Y segun el slider
    public void ChangePosY(float yPos)
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
