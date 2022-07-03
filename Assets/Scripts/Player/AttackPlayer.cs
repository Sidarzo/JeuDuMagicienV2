using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public PlayerController playerController;
    private GameObject crosshair;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        crosshair = playerController.crosshair;
    }

    public void shoot(Item spell)
    {
        switch (spell.id)
        {
            case 1:
                shootFireBall(spell);
            break;
            case 2:
                shootPowerBall(spell);
            break;
            case 3:
                useStalactites(spell);
            break;
            default:
                Debug.LogError("Spell unknow");
            break;
        }
    }
    private void shootFireBall(Item spell)
    {
        Vector2 shootingDirection = crosshair.transform.localPosition;
        shootingDirection.Normalize();
        GameObject projectile = Instantiate(spell.prefab, transform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * 8.0f;
        projectile.transform.Rotate(0, 0, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
        Destroy(projectile, 2.0f);

    }

    private void shootPowerBall(Item spell)
    {
        Vector2 shootingDirection = crosshair.transform.localPosition;
        shootingDirection.Normalize();

        if (playerController.getEndOfAiming())
        {
            GameObject projectile = Instantiate(spell.prefab, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().velocity = shootingDirection * 8.0f;
            projectile.transform.Rotate(0, 0, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
            Destroy(projectile, 2.0f);
        }
    }

    private void useStalactites(Item spell)
    {
        Vector2 shootingDirection = crosshair.transform.localPosition;
        shootingDirection.Normalize();

        if (playerController.getEndOfAiming())
        {
            GameObject projectile = Instantiate(spell.prefab, transform.position, Quaternion.identity);
            Destroy(projectile, 2.0f);
        }
    }






}
