using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private const float MoveSpeed = 3f;

    private const float PositionYLength = 11.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * (MoveSpeed * Time.deltaTime);
        
        if (transform.position.y < -PositionYLength) {
            transform.position += new Vector3(0, PositionYLength * 2f, 0);
        }

    }
}
