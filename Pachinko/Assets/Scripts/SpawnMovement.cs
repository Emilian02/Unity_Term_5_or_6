using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnMovement : MonoBehaviour
{
    private float moveSpeed = 5.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal")  * Time.deltaTime * moveSpeed, 0, 0, Space.World);
    }

}
