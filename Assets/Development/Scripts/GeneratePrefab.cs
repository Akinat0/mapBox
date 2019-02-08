using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePrefab : MonoBehaviour {

    public GameObject prefab;

    private GameObject go;

	// Use this for initialization
	void Start () {
        go = Instantiate(prefab);
        go.transform.position = transform.position;
        go.transform.localScale = new Vector3(10, 10, 10);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate(){
        go.transform.position = transform.position;
    }
}
