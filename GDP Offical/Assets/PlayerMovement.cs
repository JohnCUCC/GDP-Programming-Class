using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.RightArrow))
        {
         transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }
       
    }
}
