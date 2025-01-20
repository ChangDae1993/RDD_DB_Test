using UnityEngine;
using UnityEngine.UI;

public class npcController : MonoBehaviour
{
    public Image questMark;

    public int needLV;

    public playerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GameObject.FindAnyObjectByType<playerController>();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("player"))
        {
            if (playerController.Lv >= needLV)
            {
                questMark.enabled = true;
                Debug.Log("Quest On");
            }
            else
            {
                Debug.Log("일반 대화");
            }
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
