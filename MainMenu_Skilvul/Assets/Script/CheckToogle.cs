using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckToogle : MonoBehaviour
{
    [SerializeField]private string Check;
    [SerializeField]private string unCheck;
    private string nilai;

    public void ToggleValue(bool value)
    {
        nilai = value ? Check : unCheck;
        Debug.Log("Toggle is : " + nilai);
    }
}
