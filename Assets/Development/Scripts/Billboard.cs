using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

    [SerializeField]
    Transform target;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.LookAt(target);
	}
}
