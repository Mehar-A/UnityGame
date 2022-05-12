using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAI : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Vector3 newposition = transform.position + ((-transform.forward * Time.deltaTime));
        Vector3 newposition = new Vector3(0f, 0f, -1f);
        rb.MovePosition(transform.position + newposition * Time.deltaTime * speed); 
    }
}
