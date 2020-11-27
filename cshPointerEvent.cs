using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshPointerEvent : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Texture Texure1;
    public Texture Texure2;
    public Texture Texure3;
    public Texture Texure4;

    public GameObject cUI;

    int gazedCheck;
    // Start is called before the first frame update
    void Start()
    {
            GameObject.Find("Main Camera").transform.FindChild("WallUI").gameObject.SetActive(true);
            cUI = GameObject.Find("WallUI");
            GameObject.Find("WallUI").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gazedCheck == 1){
            if (Input.GetKey(KeyCode.E) || Input.GetButton("RB"))
            {
                cUI.SetActive(true);

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
                }
            }
            else
            {
                cUI.SetActive(false);
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
