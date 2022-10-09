using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSlider : MonoBehaviour
{
    [SerializeField] private string parameter;
    public void GetValueSlider(float value)
    {

        Debug.Log(parameter+" : "+Convert.ToInt32(value));
    }
}
