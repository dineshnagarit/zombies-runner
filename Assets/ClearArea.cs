﻿using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour
{

    public float timeSinceLastTrigger = 0f;
    private bool foundClearArea = false;


    void Update ()
    {
        timeSinceLastTrigger += Time.deltaTime;
        if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup> 10f && !foundClearArea)
        {
            Debug.Log("OnFindClearArea called");
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }
    }


    void OnTriggerStay(Collider collider)
    {
        if (collider.tag != "Player")
        {
            print("On Trigger stay called");
            timeSinceLastTrigger = 0f;
        }
    }


}
