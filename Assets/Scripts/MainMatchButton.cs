using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMatchButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x <= Input.mousePosition.x&& this.transform.position.x+1 >= Input.mousePosition.x&&this.transform.position.y <= Input.mousePosition.y && this.transform.position.y + 1 >= Input.mousePosition.y)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("click this");
            }
        }
    }
}
