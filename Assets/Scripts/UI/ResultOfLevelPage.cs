using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultOfLevelPage : MonoBehaviour
{
    public Button ToMainMenuButton;
    public Text TextBoxStaus;
    public GameObject InBattlePageMunu;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        TextBoxStaus.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TheEndOfLevel(string status)
    {
        InBattlePageMunu.SetActive(false);
        TextBoxStaus.gameObject.SetActive(true);
        TextBoxStaus.text = status;
        ToMainMenuButton.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
    }
}
