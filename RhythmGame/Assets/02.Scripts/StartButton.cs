using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class StartButton : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() =>
        {
            if (string.IsNullOrEmpty(GameManager.instance.songSelected))
                return;

            GameManager.instance.State = GameManager.GameStates.LoadSongData;
        }
    }
}
