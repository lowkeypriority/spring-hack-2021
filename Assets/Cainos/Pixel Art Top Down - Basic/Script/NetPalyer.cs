using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetPalyer : NetworkBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBodyComponent;
    //public Camera cameraObject;

    Vector2 movement;
    Vector2 mousePosition;

    private void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

      //  mousePosition = cameraObject.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
        }
       // rigidBodyComponent.MovePosition(rigidBodyComponent.position + movement * moveSpeed * Time.fixedDeltaTime);

          Vector2 lookDirection = mousePosition - rigidBodyComponent.position;
       // float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

       // rigidBodyComponent.rotation = angle;
    }
}
