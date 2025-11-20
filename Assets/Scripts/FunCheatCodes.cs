using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunCheatCodes : MonoBehaviour
{
    public ProjectileGun pGun;
    public bool p1, p2, p3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            p1 = true;
        }

        if (p1 && Input.GetKeyDown(KeyCode.I))
        {
            p2 = true;
        }

        if (p2 &&Input.GetKeyDown(KeyCode.M))
        {
            p3 = true;
        }

        if (p3 && Input.GetKeyDown(KeyCode.E))
        {
            pGun.timeBetweenShots = 0;
            pGun.reloadTime = 0;
            pGun.timeBetweenShooting = 0;
            pGun.magazineSize = 100000;
            pGun.allowButtonHold = true;
        }
    }
}
