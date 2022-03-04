using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public void ChangePosY(float yPos)
    {
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
