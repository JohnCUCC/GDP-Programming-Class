using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{ 
    public float moveSpeed;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Currently detecting" + rigidbody);
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigidbody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
    }
}
