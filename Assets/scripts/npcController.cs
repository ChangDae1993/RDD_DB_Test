using UnityEngine;
using UnityEngine.UI;

public class npcController : MonoBehaviour
{
    public Image questMark;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("player"))
        {
            questMark.enabled = true;
            Debug.Log("Quest On");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("player"))
        {
            questMark.enabled = false;
            Debug.Log("Quest Off");
        }
    }
}
