using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject chairUI;
    public GameObject elseUI;
    public GameObject tableUI;
    public GameObject doorUI;
    public GameObject makeUI;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y) || Input.GetAxisRaw("LT")!=0)
        {
            makeUI.SetActive(true);
            //의자
            if (Input.GetKey(KeyCode.U) || Input.GetAxisRaw("XboxH") < 0)
            {
                chairUI.SetActive(true);
            }
            else
            {
                chairUI.SetActive(false);
            }

            //테이블
            if (Input.GetKey(KeyCode.I) || Input.GetAxisRaw("XboxV") < 0)
            {
                tableUI.SetActive(true);
            }
            else
            {
                tableUI.SetActive(false);
            }

            //기타
            if (Input.GetKey(KeyCode.O) || Input.GetAxisRaw("XboxH") > 0)
            {
                elseUI.SetActive(true);
            }
            else
            {
                elseUI.SetActive(false);
            }

            //문
            if (Input.GetKey(KeyCode.P) || Input.GetAxisRaw("XboxV") > 0)
            {
                doorUI.SetActive(true);
            }
            else
            {
                doorUI.SetActive(false);
            }
        }
        else
        {
            makeUI.SetActive(false);
            chairUI.SetActive(false);
            elseUI.SetActive(false);
            tableUI.SetActive(false);
            doorUI.SetActive(false);
        }
    }
}
