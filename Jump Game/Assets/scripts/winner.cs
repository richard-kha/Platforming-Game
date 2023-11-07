using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winner : MonoBehaviour
{
    private Vector3 endRes;
    private Quaternion endRot;

    public Text winText;

    // Use this for initialization
    void Start()
    {
        endRes = transform.position;
        endRot = transform.rotation;
        winText.text = "";
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "winner")
        {
            transform.position = endRes;
            transform.rotation = endRot;
            GetComponent<Animator>().Play("WIN00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            winText.text = "You Win!";
        }
    }
}