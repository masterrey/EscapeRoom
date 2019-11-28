using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDisplay : MonoBehaviour
{
    public TextMesh display;
    public string password;
    bool first = true;
    public GameObject objectToactive;
    public Rigidbody rdbdoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setButtonKey(string btn)
    {
        if (first)
        {
            display.text = "";
            first = false;
        }
        if (btn=="E"){
            if (password == display.text)
            {
                display.text = "aberto";
                if (objectToactive)
                {
                    objectToactive.SetActive(true);
                }
                if (rdbdoor)
                {
                    rdbdoor.isKinematic = false;
                }

            }
            else
            {
                display.text = "errado";
                first = true;
            }
            return;
        }
        if (btn == "C")
        {
            display.text = "";
            return;
        }
        display.text += btn;
    }
}
