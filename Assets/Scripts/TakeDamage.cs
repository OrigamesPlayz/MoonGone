using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

    public float health = 5f;
    public bool isDead = false;
    public GameObject fuelRock;
    public void TakeDamageT(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            isDead = true;
        }
    }

    void Update()
    {
        if (isDead)
        {
            Instantiate(fuelRock, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
