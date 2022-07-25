using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmitter circleDataTransmitter;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float circleJumpSpeed;



    void FixedUpdate()
    {
        SetCircleJump();
    }



    private void SetCircleJump()
    {
        if (circleDataTransmitter.GetIsTouch())
        {
            rb.velocity = Vector2.up * circleJumpSpeed * Time.fixedDeltaTime;
        }
    }
}
