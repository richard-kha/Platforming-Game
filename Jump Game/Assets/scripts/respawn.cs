using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawn : MonoBehaviour
{
    private Vector3 startPos;
    private Quaternion startRot;

    public Text loseText;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
        loseText.text = "";
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "fallrespawn")
        {
            transform.position = startPos;
            transform.rotation = startRot;
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            loseText.text = "Try Again!";
            if (loseText == true)
            {
                Destroy(loseText, 3);
            }
        }
    }
}
