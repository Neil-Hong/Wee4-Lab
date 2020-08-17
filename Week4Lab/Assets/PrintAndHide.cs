using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;
        if (i == 100 && tag == "Red")
        {
            gameObject.SetActive(false);
        }

        if ((i >= 200 && i <= 250) && tag == "Blue")
        {
            gameObject.SetActive(false);
        }
    }
}
