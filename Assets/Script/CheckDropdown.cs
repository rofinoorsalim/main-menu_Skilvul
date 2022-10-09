using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckDropdown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropd;

    public void GetOption(int value)
    {
        Debug.Log(dropd.options[value].text);
    }
}
