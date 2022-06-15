using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public GameObject projectile;
    public Transform firePosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }

        void Shoot()
        {
            Instantiate(projectile, firePosition.position, firePosition.rotation);
        }
    }
}
