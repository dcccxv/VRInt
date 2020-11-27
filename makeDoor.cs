using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeDoor : MonoBehaviour
{

    public GameObject player;
    float rad;
    float crad;
    public GameObject mPos;


    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;



    int colidCheck = 0;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pos.x = mPos.transform.position.x;
        pos.y = 0f;
        rad = player.transform.eulerAngles.y;
        if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
        {
            crad = 180.0f;
        }
        if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
        {
            crad = 270.0f;//180
        }
        if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
        {
            crad = 0.0f;
        }
        if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
        {
            crad = 90.0f;//
        }


        if (crad == 270f || crad == 90f)
        {
            pos.x = mPos.transform.position.x;
        }
        else if(crad == 0f || crad == 180f)
        {
            pos.z = mPos.transform.position.z;
        }

        Quaternion qRotation = Quaternion.Euler(0f, crad, 0f);

        if (Input.GetKey(KeyCode.Y) || Input.GetAxisRaw("LT") != 0) {
            if (Input.GetKey(KeyCode.P) || Input.GetAxisRaw("XboxV") > 0)
            {
                if (colidCheck == 1)
                {
                    if (Input.GetKeyDown(KeyCode.F1) || Input.GetButtonDown("XboxX"))
                    {
                        Instantiate(door1, pos, qRotation);
                    }
                    if (Input.GetKeyDown(KeyCode.F2) || Input.GetButtonDown("XboxY"))
                    {
                        Instantiate(door2, pos, qRotation);
                    }
                    if (Input.GetKeyDown(KeyCode.F3) || Input.GetButtonDown("XboxA"))
                    {
                        pos.y = 1.2f;
                        switch (crad)
                        {
                            case 90f: pos.z -= 0.1f; break;
                            case 270f: pos.z += 0.1f; break;
                            case 0f: pos.x += 0.1f; break;
                            case 180f: pos.x -= 0.1f; break;
                        }

                        Instantiate(door3, pos, qRotation);
                    }
                    if (Input.GetKeyDown(KeyCode.F4) || Input.GetButtonDown("XboxB"))
                    {
                        pos.y = 1.3f;
                        switch (crad)
                        {
                            case 90f: pos.z -= 0.15f; break;
                            case 270f: pos.z += 0.15f; break;
                            case 0f: pos.x += 0.15f; break;
                            case 180f: pos.x -= 0.15f; break;
                        }
                        Instantiate(door4, pos, qRotation);
                    }
                }
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Debug.Log("in");
            colidCheck = 1;
            if (crad == 270f || crad == 90f)
            {
                pos.z = col.GetComponent<Transform>().position.z;
            }
            else if (crad == 0f || crad == 180f)
            {
                pos.x = col.GetComponent<Transform>().position.x;
            }
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Debug.Log("out");
            colidCheck = 0;
        }

    }

}
