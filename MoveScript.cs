
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveLookAt();
        //이동
        if (Input.GetKey(KeyCode.D) || Input.GetAxis("LstickH")>0)
        {
            transform.Translate(transform.right * 3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.right * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetAxis("LstickH") < 0)
        {
            transform.Translate(transform.right * -3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.right * -3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetAxis("LstickV") < 0)
        {
            transform.Translate(transform.forward * 3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.forward * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetAxis("LstickV") > 0)
        {
            transform.Translate(transform.forward * -3.0f * Time.deltaTime);
            //this.transform.position += (this.transform.forward * -3.0f * Time.deltaTime);
        }
        
        //시점이동
       /* if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
            //transform.Rotate(Vector3.right * 90.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
            //transform.Rotate(Vector3.left * 90.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
            //transform.Rotate(Vector3.up * 90.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
            //transform.Rotate(Vector3.down * 90.0f * Time.deltaTime);
        }*/
    }
    void MoveLookAt()
    {
        Vector3 dir = cam.transform.localRotation * Vector3.forward;
        transform.localRotation = cam.transform.localRotation;
        transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);

    }
}

