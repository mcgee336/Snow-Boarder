using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float fltorqueAmount = 1f;
    Rigidbody2D rbrb2d;
    void Start()
    {
       rbrb2d =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rbrb2d.AddTorque(fltorqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbrb2d.AddTorque(-fltorqueAmount);
        }
    }
}
