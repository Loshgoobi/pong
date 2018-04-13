using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpScript : MonoBehaviour {

    public float destroyTimer;

    private void Awake()
    {
        Destroy(gameObject, destroyTimer);
    }
}
