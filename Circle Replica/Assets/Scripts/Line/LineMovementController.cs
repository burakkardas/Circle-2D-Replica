using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;


    private void Update()
    {
        SetLineLeftMovement();
    }


    private void SetLineLeftMovement()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
