using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    private Collider textTrigger;

    [Header("Info")]
    public string Info;
    public int type = 0;//0 for flash,1 for conditioned
    public KeyCode key = KeyCode.None;
    public bool haveDone = false;
}
