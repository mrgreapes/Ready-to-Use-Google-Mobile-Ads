using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Services : SingletonMonobehaviour<Services>
{
    public bool clearPrefs;

    #region Variables
    [SerializeField]
    private PlayerService _playerService;
    [SerializeField]
    private AdsService _adsService;
    [SerializeField]
    private AudioService _audioService;
    // [SerializeField]
    // private CardsDataService _cardsService;
    private Canvas _canvas;

    #endregion

    private void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private void Update()
    {
        if (clearPrefs)
        {
            clearPrefs = false;
            PlayerPrefs.DeleteAll();
            //PlayerService.ResetPlayer();
            Debug.Log("Prefs Cleared");
        }
    }

    #region public api

    public static Canvas Canvas
    {
        get { return instance._canvas; }
    }

    public static PlayerService PlayerService
    {
        get { return instance._playerService; }
    }

    // public static CardsDataService CardsDataService
    // {
    //     get { return instance._cardsService; }
    // }
    public static AudioService AudioService
    {
        get { return instance._audioService; }
    }

    public static AdsService AdsService
    {
        get { return instance._adsService; }
    }
    #endregion
}