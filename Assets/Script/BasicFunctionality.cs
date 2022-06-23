using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicFunctionality : MonoBehaviour
{

    public Text _text;
   
    void Start()
    {
      DisableText();   
    }

  public void ShowText()
   {
      _text.gameObject.SetActive(true);
    
      
   }
   void DisableText()
   {
      _text.gameObject.SetActive(false);
   }


}
