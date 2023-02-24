using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            Destroy(instance.gameObject);

        instance= this;
        DontDestroyOnLoad(gameObject);
    }

    public enum GameStates
    {
        Idle,
        LoadSongData,
        WaitUntilSongDataLoaded,
        StartGame,
        WaitUntilGameFinished,
        DisplayScore,
        WaitForUser
    }
    public GameStates State;

    public string songSelected = string.Empty;

    private void Update()
    {
        switch (State)
        {
            case GameStates.Idle:
                break;
            case GameStates.LoadSongData:
                {
                    SceneManager.LoadScene("SongPlay");
                    SongDataLoader.Load(songSelected);
                    State = GameStates.WaitUntilSongDataLoaded;
                }
                break;
            case GameStates.WaitUntilSongDataLoaded:
                {
                    if (SongDataLoader.isLoaded)
                    {                        
                        State = GameStates.StartGame;
                    }                        
                }
                break;
            case GameStates.StartGame:
                {
                    if (MVPlayer.instance != null)
                    {
                        MVPlayer.instance.Play(SongDataLoader.clipLoaded);
                        // todo -> NoteSpawnManager ���� ��Ʈ �����ش޶�� �ϱ�
                        State = GameStates.WaitUntilGameFinished;
                    }
                }
                break;
            case GameStates.WaitUntilGameFinished:
                break;
            case GameStates.DisplayScore:
                break;
            case GameStates.WaitForUser:
                break;
            default:
                break;
        }
    }
}
