using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidad = 20;
    public float turnSpeed = 160;
    public float horizontalInput;
    public float forwadInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwadInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad * forwadInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
