using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextWiper : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        text.gameObject.SetActive(false);
    }
}
