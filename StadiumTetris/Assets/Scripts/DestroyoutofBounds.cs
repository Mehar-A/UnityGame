using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyoutofBounds : MonoBehaviour
{
    private float Boundary = -23f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < Boundary)
        {

            ScoreScript.scoreValue += 1f;
            Destroy(gameObject);
        }
    }
}
