using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    /*
    public MeshRenderer Renderer;
    public Texture Texure1;
    public Texture Texure2;
    public Texture Texure3;
    public Texture Texure4;
    */
    public GameObject player;

    Quaternion _startRotate;
    float rad;

    int gazedCheck;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // player = GameObject.Find("Player");
        rad = GameObject.Find("Player").transform.eulerAngles.y;




        if (gazedCheck == 1)
        {/*
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetButtonDown("XboxX"))
            {
                Renderer.material.SetTexture("_MainTex", Texure1);
            }
            if (Input.GetKeyDown(KeyCode.X) || Input.GetButtonDown("XboxY"))
            {
                Renderer.material.SetTexture("_MainTex", Texure2);
            }
            if (Input.GetKeyDown(KeyCode.C) || Input.GetButtonDown("XboxA"))
            {
                Renderer.material.SetTexture("_MainTex", Texure3);
            }
            if (Input.GetKeyDown(KeyCode.V) || Input.GetButtonDown("XboxB"))
            {
                Renderer.material.SetTexture("_MainTex", Texure4);
            }*/


            if (Input.GetKeyDown(KeyCode.B) || Input.GetButtonDown("XboxRsClick"))
            {
                Destroy(gameObject);
            }
            //if (Input.GetKeyDown(KeyCode.R))
            //{
            //    transform.Rotate(0, -90, 0);
            //}
            if (Input.GetKey(KeyCode.T) || Input.GetAxisRaw("RT") != 0)
            {
                if (Input.GetKey(KeyCode.D) || Input.GetAxis("LstickH") > 0)
                {
                    if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.A) || Input.GetAxis("LstickH") < 0)
                {
                    if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                    if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.W) || Input.GetAxis("LstickV") < 0)
                {
                    if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.S) || Input.GetAxis("LstickV") > 0)
                {
                    if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                    if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                }

                /*if (Input.GetKey(KeyCode.D))
                {
                    if(45 <= rad && rad < 135)
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (135 <= rad && rad < 225)
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (225 <= rad && rad < 315)
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime,Space.World);
                    }
                    if (315 <= rad || rad < 45)
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (45 <= rad && rad < 135)
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (135 <= rad && rad < 225)
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (225 <= rad && rad < 315)
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (315 <= rad || rad < 45)
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.W))
                {
                    if (45 <= rad && rad < 135)
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (135 <= rad && rad < 225)
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (225 <= rad && rad < 315)
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (315 <= rad || rad < 45)
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (45 <= rad && rad < 135)
                    {
                        transform.Translate(Vector3.right * -3.0f * Time.deltaTime, Space.World);
                    }
                    if (135 <= rad && rad < 225)
                    {
                        transform.Translate(Vector3.forward * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (225 <= rad && rad < 315)
                    {
                        transform.Translate(Vector3.right * 3.0f * Time.deltaTime, Space.World);
                    }
                    if (315 <= rad || rad < 45)
                    {
                        transform.Translate(Vector3.forward * -3.0f * Time.deltaTime, Space.World);
                    }
                }*/
            }
        }
    }
    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt)
            gazedCheck = 1;
        // Debug.Log("In");
        else
            gazedCheck = 0;

    }

}
