using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public PlayerController playerController;
    private GameObject crosshair;
    public GameObject[] prefabs;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        crosshair = playerController.crosshair;
    }

    public void shootFireBall()
    {
        Vector2 shootingDirection = crosshair.transform.localPosition;
        shootingDirection.Normalize();

        if (playerController.getEndOfAiming())
        {
            GameObject projectile = Instantiate(prefabs[0], transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * 8.0f;
            projectile.transform.Rotate(0, 0, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
            Destroy(projectile, 2.0f);
        }
    }




}
