using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI songText;
    
    
    private int start = 10;

    private void Start()
    {
        StartCoroutine("SongCoroutine");
    }

    private IEnumerator SongCoroutine()
    {
        for (int i = start; i > 0; i--)
        {
            songText.text = "";
            for (int j = 0; j < 2; j++)
            {
                yield return StartCoroutine(NewSentence($"{i} green bottles\n"));
                yield return StartCoroutine(NewSentence("Hanging on the wall\n"));
            }
            
            yield return StartCoroutine(NewSentence("And if one green bottle\n"));
            yield return StartCoroutine(NewSentence("Should accidentally fall\n"));
            yield return StartCoroutine(NewSentence($"There'll be {i - 1} bottles\n"));
            yield return StartCoroutine(NewSentence("Hanging on the wall\n"));
            
        }

        songText.fontSize = 200f;
        songText.text = "The end";
    }

    private IEnumerator NewSentence(string newSentence)
    {
        songText.text += newSentence;
        yield return new WaitForSeconds(0.5f);
    }

}
