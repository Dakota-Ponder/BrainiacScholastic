using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
}
