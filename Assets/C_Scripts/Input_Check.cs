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

    public Boolean Trigger_Left_bool = false;
    public Boolean Trigger_Right_bool = false;
    public Boolean Pollice_Left_bool = false;
    public Boolean Pollice_Right_bool = false;
    public Boolean Indice_Left_bool = false;
    public Boolean Indice_Right_bool = false;
    public Boolean Test_Spell = false;

    void Update()
    {
        if (trigger_Left.action.IsPressed())
        {
           
            Trigger_Left_bool = true;
        }
        else
        {
            Trigger_Left_bool = false;
        }

      


        if (trigger_right.action.IsPressed())
        {
            Trigger_Right_bool = true;

        }
        else
        {
            Trigger_Right_bool = false;
        }


        if (pollice_right.action.IsPressed())
        {
            Pollice_Right_bool = true;

        }
        else
        {
            Pollice_Right_bool = false;
        }


        if (pollice_left.action.IsPressed())
        {
            Pollice_Left_bool = true;

        }
        else
        {
            Pollice_Left_bool = false;
        }


        if (indice_Left.action.IsPressed())
        {
            Indice_Left_bool = true;

        }
        else
        {
            Indice_Left_bool = false;
        }


        if (indice_right.action.IsPressed())
        {
            Indice_Right_bool = true;

        }
        else
        {
            Indice_Right_bool = false;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Aiuto");
            Trigger_Left_bool = true;
        }
        else
        {
            Trigger_Left_bool = false;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Help");
            Trigger_Right_bool = true;
        }
        else
        {
            Trigger_Right_bool = false;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("E de mua");
            Pollice_Right_bool = true;
        }
        else
        {
            Pollice_Right_bool = false;
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Aiutar");
            Pollice_Left_bool = true;
        }
        else
        {
            Pollice_Left_bool = false;
        }


        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Dolores");
            Test_Spell = true;
        }
        else
        {
            Test_Spell = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Dolores");
            Indice_Left_bool = true;
        }
        else
        {
            Indice_Left_bool = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Dolores");
            Indice_Right_bool = true;
        }
        else
        {
            Indice_Right_bool = false;
        }
    }
}