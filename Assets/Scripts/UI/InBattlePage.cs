using UnityEngine;
using UnityEngine.UI;

public class InBattlePage : MonoBehaviour
{
    public GameController Controller;
    public Button AttackButton;
    public Button SwitchButton;
    public Button PauseButton;
    public Button ResumeButton;
    public Button RevengeButton;
    public Button ToMainMenuButton;
    public Text TextBoxStaus;

    private void Start()
    {
        ResumeButton.gameObject.SetActive(false);
        RevengeButton.gameObject.SetActive(false);
        ToMainMenuButton.gameObject.SetActive(false);
        TextBoxStaus.gameObject.SetActive(false);
    }
    private void Awake()
    {
        AttackButton.onClick.AddListener(OnAttackButtonClick);
        SwitchButton.onClick.AddListener(() => Controller.SwitchCharacter());
        PauseButton.onClick.AddListener(OnPauseButtonClick);
        ResumeButton.onClick.AddListener(OnPauseButtonClick);
    }

    private void OnAttackButtonClick()
    {
        Controller.PlayerMove();
    }

    private void OnPauseButtonClick()
    {
        if (!ResumeButton.gameObject.activeSelf)
        {
            Time.timeScale = 0;
            PauseButton.gameObject.SetActive(false);
            ResumeButton.gameObject.SetActive(true);
            RevengeButton.gameObject.SetActive(true);
            ToMainMenuButton.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PauseButton.gameObject.SetActive(true);
            ResumeButton.gameObject.SetActive(false);
            RevengeButton.gameObject.SetActive(false);
            ToMainMenuButton.gameObject.SetActive(false);
        }

    }

    public void TheEndOfLevel(string status)
    {
        TextBoxStaus.gameObject.SetActive(true);
        TextBoxStaus.text = status;
        ToMainMenuButton.gameObject.SetActive(true);
    }
}
