using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    
    private int start = 10;

    private void Start()
    {
        StartCoroutine("CounterCoroutine");
    }

    private IEnumerator CounterCoroutine()
    {
        for (int i = start; i >= 0; i--)
        {
            counterText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
    }
    
}
