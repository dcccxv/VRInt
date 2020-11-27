using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
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
        rad = GameObject.Find("Player").transform.eulerAngles.y;

        if (gazedCheck == 1)
        {
            if (Input.GetKeyDown(KeyCode.B) || Input.GetButtonDown("XboxRsClick"))
            {
                Destroy(gameObject);
            }

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
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("111");
    }
    void OnTriggerExit(Collider col)
    {
        Debug.Log("2221");
        Destroy(gameObject);
    }
}
