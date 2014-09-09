using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour
{
    private bool _sound;
    public bool Sound
    {
        get { return _sound ;}
        set { _sound = value ;}
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
