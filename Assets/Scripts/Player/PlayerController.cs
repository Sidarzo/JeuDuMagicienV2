using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 input;





    private bool isMoving;
    public LayerMask solidObjectsLayer;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Start()
    {

    }

    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        animator.SetFloat("moveX", input.x);
        animator.SetFloat("moveY", input.y);
        animator.SetFloat("speed", input.sqrMagnitude);
        rb.MovePosition(rb.position + input * moveSpeed * Time.fixedDeltaTime);


        flip();
    }

    void flip()
    {
        if(input.x >= 0 && input.y < 0)
        {
            Debug.Log('N');
            transform.Rotate(0f, 0f, 0f);
        }
        else if (input.x >= 0 && input.y >= 1)
        {
            // up
            Debug.Log('U');
            transform.Rotate(0f, 180f, 0f);

        }
        else if(input.x < 0 && input.y >= 0)
        {
            // left
            Debug.Log('L');
            transform.Rotate(180f, 0f, 0f);

        }
        else if(input.x >= 1 && input.y <= 0)
        {
            // righ
            Debug.Log('D');
            transform.Rotate(0f, 0f, 180f);

        }
    }


    //void Update()
    //{
    //    if (!isMoving)
    //    {
    //        input.x = Input.GetAxisRaw("Horizontal");
    //        input.y = Input.GetAxisRaw("Vertical");

    //        if(input != Vector2.zero)
    //        {
    //            animator.SetFloat("moveX", input.x);
    //            animator.SetFloat("moveY", input.y);
    //            var targetPos = transform.position;
    //            targetPos.x += input.x;
    //            targetPos.y += input.y;


    //            if (IsWalkable(targetPos)) StartCoroutine(Move(targetPos));
    //        }
    //    }

    //    animator.SetBool("isMoving", isMoving);

    //    IEnumerator Move(Vector3 targetPos)
    //    {
    //        isMoving = true;
    //        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
    //        {
    //            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    //            yield return null;
    //        }
    //        transform.position = targetPos;
    //        isMoving = false;
    //    }

}

//public bool IsWalkable(Vector3 targetPos)
//{
//    if(Physics2D.OverlapCircle(targetPos, 0.1f, solidObjectsLayer) != null)
//    {
//        return false;
//    }

//    return true;
//}
//}
