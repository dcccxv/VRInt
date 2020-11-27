using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeObject : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    float rad;
    float crad;
    public GameObject mPos;

    public GameObject chair1;
    public GameObject chair2;
    public GameObject chair3;
    public GameObject chair4;

    public GameObject table1;
    public GameObject table2;
    public GameObject table3;
    public GameObject table4;

    public GameObject else1;
    public GameObject else2;
    public GameObject else3;
    public GameObject else4;

    public GameObject door;

    public GameObject Wall;


    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = mPos.transform.position;
        pos.y = 0f;
        rad = player.transform.eulerAngles.y;
        if ((22.5 <= rad && rad < 67.5) || (202.5 <= rad && rad < 247.5))
        {
            crad = 270.0f;
        }
        if ((67.5 <= rad && rad < 112.5) || (247.5 <= rad && rad < 292.5))
        {
            crad = 0.0f;
        }
        if ((112.5 <= rad && rad < 157.5) || (292.5 <= rad && rad < 337.5))
        {
            crad = 90.0f;
        }
        if (337.5 <= rad || rad < 22.5 || (157.5 <= rad && rad < 202.5))
        {
            crad = 180.0f;
        }

        Quaternion qRotation = Quaternion.Euler(0f, crad, 0f);
        if (Input.GetKey(KeyCode.Y) || Input.GetAxisRaw("LT") != 0)
        {
            //의자
            if (Input.GetKey(KeyCode.U) || Input.GetAxisRaw("XboxH") < 0)
            {
                if (Input.GetKeyDown(KeyCode.F1) || Input.GetButtonDown("XboxX"))
                {
                    Instantiate(chair1, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F2) || Input.GetButtonDown("XboxY"))
                {
                    Instantiate(chair2, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F3) || Input.GetButtonDown("XboxA"))
                {
                    Instantiate(chair3, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F4) || Input.GetButtonDown("XboxB"))
                {
                    Instantiate(chair4, pos, qRotation);
                }
            }

            //테이블
            if (Input.GetKey(KeyCode.I) || Input.GetAxisRaw("XboxV") < 0)
            {
                if (Input.GetKeyDown(KeyCode.F1) || Input.GetButtonDown("XboxX"))
                {
                    Instantiate(table1, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F2) || Input.GetButtonDown("XboxY"))
                {
                    Instantiate(table2, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F3) || Input.GetButtonDown("XboxA"))
                {
                    Instantiate(table3, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F4) || Input.GetButtonDown("XboxB"))
                {
                    Instantiate(table4, pos, qRotation);
                }
            }

            //기타
            if (Input.GetKey(KeyCode.O) || Input.GetAxisRaw("XboxH") > 0)
            {
                if (Input.GetKeyDown(KeyCode.F1) || Input.GetButtonDown("XboxX"))
                {
                    Instantiate(else1, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F2) || Input.GetButtonDown("XboxY"))
                {
                    Instantiate(else2, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F3) || Input.GetButtonDown("XboxA"))
                {
                    Instantiate(else3, pos, qRotation);
                }
                if (Input.GetKeyDown(KeyCode.F4) || Input.GetButtonDown("XboxB"))
                {
                    Instantiate(else4, pos, qRotation);
                }
            }
        }

        //벽만들기
        if (Input.GetKeyDown(KeyCode.F12) || Input.GetButtonDown("XboxM"))
        {
            Vector3 wpos;
            wpos.x = pos.x; wpos.y = pos.y; wpos.z = pos.z;
            switch (crad)
            {
                case 270.0f:
                    if (pos.z < 0)
                        wpos.z = (pos.z - 12);
                    else
                        wpos.z = (pos.z + 12);
                    break;
                case 0.0f:
                    if (pos.x < 0)
                        wpos.x = (pos.x - 12);
                    else
                        wpos.x = (pos.x + 12);
                    break;
                case 90.0f:
                    if (pos.z < 0)
                        wpos.z = (pos.z - 12);
                    else
                        wpos.z = (pos.z + 12);
                    break;
                case 180.0f:
                    if(pos.x < 0)
                        wpos.x = (pos.x - 12);
                    else
                        wpos.x = (pos.x + 12);
                    break;

            }
            Instantiate(Wall, wpos, qRotation);
        }
    }

}
