using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceController : MonoBehaviour
{
    public TextMeshProUGUI text;
    int number;
    bool updateUI;
    bool pointerDown;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(updateUI)
        {
            updateUI = false;
            UpdateUI();
        }

        if(pointerDown)
        {
            IncreaseNumber();
        }
    }

    void UpdateUI()
    {
        text.text = number.ToString();
    }

    void IncreaseNumber()
    {
        number += 50;
        updateUI = true;
    }

    public void PointerDown()
    {
        pointerDown = true;
    }

    public void PointerUp()
    {
        pointerDown = false;
    }
}
