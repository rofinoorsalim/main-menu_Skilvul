using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour
{
    [SerializeField] private string Text;

    public void ShowText()
    {
        Debug.Log(Text);
    }
}
