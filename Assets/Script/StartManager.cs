using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{
    [SerializeField] private bool isGameStarted = false;
    [SerializeField] private TextMeshProUGUI textUI;
    [SerializeField] private string newText = "ゲームスタート";
    [SerializeField] private float displayTime = 3f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(!isGameStarted)
            {
                isGameStarted = true;
                StartGame();
            }
        }
    }

    void StartGame()
    {
        textUI.text = newText;

        StartCoroutine(HideUI(displayTime));
    }

    IEnumerator HideUI(float delay)
    {
        yield return new WaitForSeconds(delay);

        textUI.gameObject.SetActive(false);
    }
}
