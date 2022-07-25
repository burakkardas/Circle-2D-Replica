using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    void Update()
    {
        CheckLineObjectPosition();
    }


    private void CheckLineObjectPosition()
    {
        if (transform.position.x <= -4f)
        {
            Destroy(gameObject);
        }
    }
}
