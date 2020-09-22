using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSwitch : MonoBehaviour
{
    public Button leftBtn, rightBtn;
    public List<Transform> characterBuffer;
    bool updateUI;
    int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
        UpdateCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        if(updateUI)
        {
            updateUI = false;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        Debug.Log(currentIndex);
        leftBtn.interactable = currentIndex > 0;
        rightBtn.interactable = currentIndex < characterBuffer.Count - 1;    
    }

    void UpdateCharacter()
    {
        for(int i = 0; i < characterBuffer.Count; i++)
        {
            characterBuffer[i].gameObject.SetActive(i == currentIndex);
        }
    }

    public void SwutchCharacter(bool leftOrRight)
    {
        currentIndex += leftOrRight? -1:1;
        updateUI = true;
    }
}
