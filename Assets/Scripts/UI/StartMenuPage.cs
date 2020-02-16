using UnityEngine;
using UnityEngine.UI;

public class StartMenuPage : MonoBehaviour
{
    public string BattleSceneName;
    public Button PlayButton;
    public LoadingLogicPage LoadingLogic;

    private void Awake()
    {
        PlayButton.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        Time.timeScale = 1;
        LoadingLogic.LoadScene(BattleSceneName);
    }
}
