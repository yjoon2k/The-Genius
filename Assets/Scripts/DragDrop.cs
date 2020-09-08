using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startPosition;
    public GameObject Card;

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Card.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
           
    }

    public void StartDrag()
    {

        startPosition = Card.transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
    }
}
