using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    [SerializeField] public float typeSpeed = .05f;
    public GameObject Continue_button;
    public GameObject Spawnner;
   
    private void Start()
    {
        // Hexagon.SetActive(false);
        Spawnner.SetActive(false);
        StartCoroutine(Type());
        
    }
    public void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            Continue_button.SetActive(true);
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }
    public void NextSentecne()
    {
        Continue_button.SetActive(false);
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            Continue_button.SetActive(false);
            // Hexagon.SetActive(true);
            Spawnner.SetActive(true);
        }
    }
}
