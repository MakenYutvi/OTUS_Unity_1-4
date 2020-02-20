using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public Button RevengeButton;
    public Button ToMainMenuButton;
    public Image image;
    public string MainMenuSceneName;
    public string CurentSceneName;
    public LoadingLogicPage LoadingLogic;
    public GameObject InBattlePageMunu;

    private void Start()
    {
        ResumeButton.gameObject.SetActive(false);
        RevengeButton.gameObject.SetActive(false);
        ToMainMenuButton.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }
    private void Awake()
    {
        PauseButton.onClick.AddListener(OnPauseButtonClick);
        ResumeButton.onClick.AddListener(OnPauseButtonClick);
        ToMainMenuButton.onClick.AddListener(OnToMainMenuButtonClick);
        RevengeButton.onClick.AddListener(OnRevengeButtonClick);
    }

    private void OnPauseButtonClick()
    {
        if (!ResumeButton.gameObject.activeSelf)
        {
            Time.timeScale = 0;
            InBattlePageMunu.SetActive(false);
            PauseButton.gameObject.SetActive(false);
            ResumeButton.gameObject.SetActive(true);
            image.gameObject.SetActive(true);
            RevengeButton.gameObject.SetActive(true);
            ToMainMenuButton.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            InBattlePageMunu.SetActive(true);
            PauseButton.gameObject.SetActive(true);
            ResumeButton.gameObject.SetActive(false);
            RevengeButton.gameObject.SetActive(false);
            image.gameObject.SetActive(false);
            ToMainMenuButton.gameObject.SetActive(false);
        }

    }

    private void OnToMainMenuButtonClick()
    {
        Time.timeScale = 1;
        LoadingLogic.LoadScene(MainMenuSceneName);
    }
    private void OnRevengeButtonClick()
    {
        Time.timeScale = 1;
        LoadingLogic.LoadScene(CurentSceneName);
    }
}
