using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI displayedText;

    public int clickCount { get; private set;}
    // Start is called before the first frame update
    void Start()
    {
         
    }
    public void OnMouseDown()
    {
        IncreaseCount();
        DisplayMessage();
    }
  
    public void DisplayMessage()
    {
        UpdateMessage();
        displayedText.gameObject.SetActive(true);
    }
    public virtual void UpdateMessage()
    {
        displayedText.SetText("This is the default text of the shape class.");
    }
    public void UpdateMessage(string textToSet)
    {
        displayedText.SetText(textToSet);
    }
    public void IncreaseCount()
    {
        if (clickCount.Equals(null))
        {
            clickCount = 0;
        }
        clickCount++;
    }
}
