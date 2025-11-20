using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowCam : MonoBehaviour
{
    public Transform playerCam;
    public float followSpeed = 5f;
    public Vector3 offset = new Vector3(0.3f, -0.4f, 0.5f);

    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position, 
            playerCam.position + offset, 
            followSpeed * Time.deltaTime
        );
    }
}
