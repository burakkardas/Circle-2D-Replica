using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    [SerializeField] private float rotationValue;
    private float randomRotation;


    private void Start()
    {
        GenerateRandomRotationValue();
        SetLineRandomRotation();
    }



    private void GenerateRandomRotationValue()
    {
        randomRotation = Random.Range(-rotationValue, rotationValue);
    }



    private void SetLineRandomRotation()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, randomRotation);
    }
}
