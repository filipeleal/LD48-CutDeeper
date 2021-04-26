using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeBehaviour : MonoBehaviour
{

    public CharacterBehaviour Player;

    public Image[] Layers;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(var layer in Layers)
        {
            layer.enabled = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        int health = Player.Health;
        for(int i = 0; i< Layers.Length; i++)
        {
            if (i <= health-1)
            {
                Layers[i].enabled = true;
            }
            else
                Layers[i].enabled = false;
        }
        
    }
}
