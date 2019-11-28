using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire2"))
        {
            Cursor.visible = false;
            transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"), 0), Space.World);
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, 0), Space.Self);
        }
        else
        {
            
            Cursor.visible = true;
        }
        if (Input.GetButton("Fire1") && !Input.GetButton("Fire3"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit, 100))
            {
                print(hit.collider.name);
                if (hit.collider.tag == "GameController")
                {
                    hit.collider.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward*10,hit.point);

                }
            }

        }
        if (Input.GetButton("Fire1") && Input.GetButton("Fire3"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                print(hit.collider.name);
                if (hit.collider.tag == "GameController")
                {
                    hit.collider.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * -10, hit.point);

                }
            }

        }
    }
}
