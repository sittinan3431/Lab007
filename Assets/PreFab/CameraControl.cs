using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 offset;
    public GameObject ballPlayer;
    void Start()
    {
        offset = this.transform.position - ballPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = offset + ballPlayer.transform.position;
    }
}
