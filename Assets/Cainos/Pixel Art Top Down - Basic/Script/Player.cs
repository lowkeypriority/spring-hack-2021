using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBodyComponent;
    public Camera cameraObject;

    private float jerkTime = 10;
    private bool isJerk = false;

    Vector2 movement;
  //  Vector2 mousePosition;



    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //mousePosition = cameraObject.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKey(KeyCode.R) && !isJerk)
        {
            StartCoroutine(Jerk());
        }
    }


    private IEnumerator Jerk()
    {
        isJerk = true;
        moveSpeed *= 6f;
        yield return new WaitForSeconds(0.1f);
        moveSpeed = 5f;
        yield return new WaitForSeconds(jerkTime);
        isJerk = false;
    }

    private void FixedUpdate()
    {
        rigidBodyComponent.MovePosition(rigidBodyComponent.position + movement * moveSpeed * Time.fixedDeltaTime);

       // Vector2 lookDirection = mousePosition - rigidBodyComponent.position;
       // float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

       // rigidBodyComponent.rotation = angle;
    }
}
