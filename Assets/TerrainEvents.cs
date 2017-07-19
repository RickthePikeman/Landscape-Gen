using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainEvents : MonoBehaviour {

    public Material[] materials;
    //public Renderer rend;
    public MeshRenderer rend;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        rend.enabled = true;
        //materials = rend.GetComponents<Material>();
        //rend.sharedMaterial = materials[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp()
    {
        //Debug.Log(materials.Length);
        rend.sharedMaterial = materials[1];

    }
}
