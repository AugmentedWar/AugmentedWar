using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    public Joystick joystick;
    public int speed;
    float vertical, horizontal;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        vertical = joystick.Vertical;
        horizontal = joystick.Horizontal;

       
           
           
            transform.up = new Vector3(horizontal * 0 , 0);
            transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime, Space.World);
        
    }
}
