using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG_CharMove : MonoBehaviour
{
    public float m_Speed = 5f;
    void Update()
    {

        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        transform.GetComponent<Rigidbody>().MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);

        // if (Input.GetKeyDown(KeyCode.UpArrow))
        // {
            
        // }

    }
}
