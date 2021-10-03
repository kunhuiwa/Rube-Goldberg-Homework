using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
    public GameObject Block;
    private bool activate;

    // Start is called before the first frame update
    
    void Start()
    {
        Block.SetActive(false);
        activate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (activate == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Block.SetActive(true);
                Debug.Log("Space was pressed");
            }
        }
        else
        {
            Block.SetActive(false);
            Debug.Log("Not active");
        }
    }
}
