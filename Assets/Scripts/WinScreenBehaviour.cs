using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenBehaviour : MonoBehaviour
{
    void OnNewGame()
    {
        GameManager.Instance.NewGame();
    }
}
