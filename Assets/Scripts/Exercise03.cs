using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise03 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;
    
    
    private string message = "¡Hola, holita, vecinito!";

    private void Start()
    {
        StartCoroutine("MessageCoroutine");
    }

    private IEnumerator MessageCoroutine()
    {
        messageText.text = "";
        foreach (char letter in message)
        {
            yield return new WaitForSeconds(0.2f);
            messageText.text += letter;
        }
    }
}
