using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector2 movementDirection;
    public float movementSpeed;
    public float playerSpeed;
    private bool endOfAiming;

    public GameObject crosshair;

    private float crosshairDistance;

    private Rigidbody2D rb;
    private Animator animator;

    public InvManagement inv;
    public AttackPlayer attackPlayer;

    // HealthController

    public int maxHealth;
    public HealthManagement healthManagement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        playerSpeed = 5.0f;
        crosshairDistance = 1.0f;
        // Health
        maxHealth = 100;
       // healthManagement.SetMaxHealth(maxHealth);

    }

    private void Update()
    {
        ProcessInputs();
        Move();
        Animate();
        Aim();
        Shoot();
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementSpeed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 1.0f);
        movementDirection.Normalize();

        endOfAiming = Input.GetButtonUp("Fire1");
    }

    void Move()
    {
        rb.velocity = movementDirection * movementSpeed * playerSpeed;
    }

    void Animate()
    {
        if(movementDirection != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movementDirection.x);
            animator.SetFloat("Vertical", movementDirection.y);
        }
        animator.SetFloat("Speed", movementSpeed);
    }

    void Aim()
    {
        if(movementDirection != Vector2.zero)
        {
            crosshair.transform.localPosition = movementDirection * crosshairDistance;
        }
    }

    void Shoot()
    {
        if (endOfAiming)
        {
            Item spell = inv.GetSelectedSpell();
            attackPlayer.shoot(spell);
        }
    }

    public bool getEndOfAiming()
    {
        return endOfAiming;
    }

}





  
