using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform camPos;
    public Transform camPos2;
    void Update()
    {
        transform.position = camPos.position;
        transform.position = camPos2.position;
    }
}
