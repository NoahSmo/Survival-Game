using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    
    [SerializeField]
    private Text headerField;
    
    
    [SerializeField]
    private Text contentField;

    [SerializeField]
    private LayoutElement layoutElement;

    [SerializeField] private int maxCharacter;

    public void SetText(string content, string header = "")
    {
        if (header == "")
        {
            headerField.gameObject.SetActive(false);
        }
        else
        {
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }

        contentField.text = content;
        
        int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        layoutElement.enabled = (headerLength > maxCharacter || contentLength > maxCharacter) ? true : false;
    }
}
