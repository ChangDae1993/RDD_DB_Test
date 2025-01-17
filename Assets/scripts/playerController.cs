using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            Debug.Log("Right");
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("Left");
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Debug.Log("Up");

        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            Debug.Log("Down");
        }
    }
}
