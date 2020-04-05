using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    Vector2 movement = new Vector2();
    Rigidbody2D rb2D;

    Animator animator;

    enum CharStates
    {
        walkEast = 1,
        walkSouth = 2,
        walkWest = 3,
        walkNorth = 4,

        idleSouth = 5
    }


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    void FixedUpdate()
    {
        MoveCharacter();
    }


    #region Helper
    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rb2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        if (movement.x > 0)
        {
            animator.SetInteger("AnimationState", (int)CharStates.walkEast);
        }
        else if (movement.x < 0)
        {
            animator.SetInteger("AnimationState", (int)CharStates.walkWest);
        }
        else if (movement.y > 0)
        {
            animator.SetInteger("AnimationState", (int)CharStates.walkNorth);
        }
        else if (movement.y < 0)
        {
            animator.SetInteger("AnimationState", (int)CharStates.walkSouth);
        }
        else
        {
            animator.SetInteger("AnimationState", (int)CharStates.idleSouth);
        }
    }
    #endregion
}
