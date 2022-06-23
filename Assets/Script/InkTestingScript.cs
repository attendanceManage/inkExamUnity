using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkTestingScript : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story;
    public Text textPrefab;
    void Start()
    {
        story = new Story(inkJSON.text);
        loadStoryChunk();

    }

    string loadStoryChunk()
    {
        string text = "";
        while(story.canContinue)
        {
          string currentTextChunk = story.Continue();  
          text += currentTextChunk;
        }

       return textPrefab.text = text;
    }
}