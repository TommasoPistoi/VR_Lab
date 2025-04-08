using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using System;

public class inputtesting : MonoBehaviour
{
    public InputActionReference trigger_Left;
    public InputActionReference trigger_right;
    public InputActionReference indice_Left;
    public InputActionReference indice_right;
    public InputActionReference pollice_left;
    public InputActionReference pollice_right;

    public Material newmaterial;
    public Material oldmaterial;
    public Boolean Trigger_Left_bool = false;
    public Boolean Trigger_Right_bool = false;
    public Boolean Pollice_Left_bool = false;
    public Boolean Pollice_Right_bool = false;
    public Boolean Indice_Left_bool = false;
    public Boolean Indice_Right_bool = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (indice_Left.action.IsPressed())
        {
            GetComponent<Renderer>().material = newmaterial;

        }
        else GetComponent<Renderer>().material = oldmaterial;
    }


}