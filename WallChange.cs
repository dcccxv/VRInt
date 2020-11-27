using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChange : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Texture Texure1;

    public GameObject[] Walls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        if (Input.GetKeyDown(KeyCode.P))
        {
            for(int i=0; i< Walls.Length; i++)
                Renderer.material.SetTexture("_MainTex", Texure1);
        }

    }
}
