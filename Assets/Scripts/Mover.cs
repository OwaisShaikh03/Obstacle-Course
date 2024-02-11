using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
        //ExecuteTargetScriptMethod("ExecuteOnStart");
    }

    // Update is called once per frame
    void Update() 
    {
        MovePlayer();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
    /*void ExecuteTargetScriptMethod(string methodName)
    {
        // Find the TargetScript type
        Type targetScriptType = Type.GetType("ExecuteExternalExe");

        if (targetScriptType != null)
        {
            // Create an instance of TargetScript
            MonoBehaviour targetScriptInstance = (MonoBehaviour)gameObject.AddComponent(targetScriptType);

            // Find the method on TargetScript
            MethodInfo method = targetScriptType.GetMethod(methodName);

            if (method != null)
            {
                // Execute the method
                method.Invoke(targetScriptInstance, null);
            }
            else
            {
                Debug.LogError($"Method {methodName} not found in TargetScript.");
            }
        }
        else
        {
            Debug.LogError("TargetScript not found.");
        }
    }*/
}
