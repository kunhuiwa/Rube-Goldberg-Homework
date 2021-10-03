using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public Camera oneCam;
    public Camera twoCam;
    public Camera threeCam;
    public Camera fourCam;
    public Camera fiveCam;
    public Camera sixCam;

    // Start is called before the first frame update
    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.isTrigger = true;
        oneCam.enabled = true;
        twoCam.enabled = false;
        threeCam.enabled = false;
        fourCam.enabled = false;
        fiveCam.enabled = false;
        sixCam.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("The player has gone through the trigger",gameObject);
            oneCam.enabled = false;
            twoCam.enabled = true;
            threeCam.enabled = false;
            fourCam.enabled = false;
            fiveCam.enabled = false;
            sixCam.enabled = false;
        }
    }
}
