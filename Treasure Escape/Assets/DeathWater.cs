using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWater : MonoBehaviour {

    public float death;

    // Start is called before the first frame update
    void FixedUpdate () {
        if (transform.position.y < death){
            transform.position = new Vector3(183.8f, -10.6f, 304.1f);
        }
    }
}
