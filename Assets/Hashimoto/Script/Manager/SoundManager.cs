using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    const string TITLE_SCENE_NAME = "TitleScene";
    const string GAME_SCENE_NAME = "GameScene";
    const string RESULT_SCENE_NAME = "ResultScene";

    AudioSource _audioSource;

    [SerializeField]
    SoundSFX[] _soundList;


    protected override void Awake()
    {
        base.Awake();

        if (TryGetComponent(out _audioSource))
        {
            Debug.Log("オーディオソースが参照できた");
        }

        FirstBGM();
    }

    void FirstBGM()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case TITLE_SCENE_NAME:
                //_audioSource.clip = _soundList[];
                break;

            case GAME_SCENE_NAME:
                //_audioSource.clip = _soundList[];
                break;

            case RESULT_SCENE_NAME:
                //_audioSource.clip = _soundList[2].Clips;
                break;
        }

        _audioSource.Play();
    }

    public void PlayBGM(BGMType type)
    {
        switch (type)
        {
            case BGMType.Title:
                //_audioSource.clip = _soundList[0].Clips;
                break;

            case BGMType.Game:
                //_audioSource.clip = _soundList[1].Clips;
                break;

            case BGMType.Result:
                //_audioSource.clip = _soundList[2].Clips;
                break;
        }

        _audioSource.Play();
    }

    public void PlaySFX(SFXType type)
    {
        var s = Array.Find(_soundList, e => e.Type == type);
        if(s != null)
        {
            _audioSource.PlayOneShot(s.Clip);
        }
        else
        {
            Debug.LogError("AudioClipがないです");
        }
    }

    [Serializable]
    public class SoundSFX
    {
        public AudioClip Clip => _clip;

        public SFXType Type => _type;

        [SerializeField]
        SFXType _type;

        [SerializeField]
        AudioClip _clip;

    }
    [Serializable]
    public class SoundBGM
    {
        public AudioClip Clip => _clip;

        [SerializeField]
        BGMType _type;

        [SerializeField]
        AudioClip _clip;
    }
}
