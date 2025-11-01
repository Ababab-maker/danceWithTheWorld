using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public int targetSceneIndex;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                GameManager.instance.LoadScene(targetSceneIndex);
            }
        }   
    }
}
