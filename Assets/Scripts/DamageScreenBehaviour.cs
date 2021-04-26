using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScreenBehaviour : MonoBehaviour
{
    public void NewRound()
    {
        GameManager.Instance.NewRound();
    }

    public void GameOver()
    {
        GameManager.Instance.GameOver();
    }
}
