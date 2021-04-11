using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipScreenSpaceUI : MonoBehaviour
{
    private RectTransform backgroundRectTransform;
    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        backgroundRectTransform = transform.Find("background").GetComponent<RectTransform>();
        textMeshPro = transform.Find("text").GetComponent<TextMeshProUGUI>();

        SetText("Hello World");
    }

    private void SetText(string tooltipText)
    {
        textMeshPro.SetText(tooltipText);
    }
}
