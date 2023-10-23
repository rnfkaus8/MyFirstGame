using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 3f;
    private float positionYLength = 11.5f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        if (transform.position.y < -positionYLength) {
            transform.position += new Vector3(0, positionYLength * 2.0, 0);
        }

    }
}
