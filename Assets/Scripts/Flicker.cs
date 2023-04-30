using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flicker : MonoBehaviour
{
    public float oscillationSpeed = 1.0f;
    public float minOpacity = 0.0f;
    public float maxOpacity = 1.0f;

    private TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float opacity = Mathf.Lerp(minOpacity, maxOpacity, Mathf.PingPong(Time.time * oscillationSpeed, 1.0f));
        Color color = text.color;
        color.a = opacity;
        text.color = color;
    }
}