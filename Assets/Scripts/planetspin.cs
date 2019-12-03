using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetspin : MonoBehaviour
{
    private Vector3 direction = new Vector3(1, 0, 0);
    private Vector3 rotateDirection = new Vector3(0, 0, 1);

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime); //taken from Unity Documentation
        }
}
