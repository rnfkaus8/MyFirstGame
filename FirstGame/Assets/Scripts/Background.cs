using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -11.5) {
            transform.position += new Vector3(0, 22.5f, 0);
        }

    }
}
