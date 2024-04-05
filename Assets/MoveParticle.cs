using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedMove = 5f;

    void Update()
    {
        float 
            horInput = Input.GetAxis("Horizontal"), 
            verInput = Input.GetAxis("Vertical");

        Vector3
            direction = new Vector3(horInput, 0.0f, verInput);

        transform.Translate(direction * speedMove * Time.deltaTime);
    }
}
