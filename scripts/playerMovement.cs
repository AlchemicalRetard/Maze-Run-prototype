using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Animator ani; 
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        Debug.Log("animator");
    }

    // Update is called once per frame
    void Update()
    {
        bool forward = Input.GetKey("w");
        bool a = Input.GetKey("a");
        bool d = Input.GetKey("d");
        if (forward ^ a ^d)
        {
            ani.SetBool("isRunning", true);
        }

        if (!forward ^ !a ^ !d)
        {
            ani.SetBool("isRunning", false);
        }
    }
}
