using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goalText;
    [SerializeField] private PlayerMove playerMove;
  
    // Start is called before the first frame update
    void Start()
    {
        if(goalText!=null)
        {
            goalText.gameObject.SetActive(false);
        }

        playerMove = GetComponent<PlayerMove>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Goal"))
        {
            goalText.gameObject.SetActive(true);

            if(playerMove!=null)
            {
                playerMove.enabled = false;
            }
        }

        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
