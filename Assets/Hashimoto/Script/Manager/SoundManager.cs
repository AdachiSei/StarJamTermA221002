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

    AudioSource _audioSource;// ����炷���߂̂���

    [SerializeField]
    [Header("���ʉ��n")]
    SoundSFX[] _soundSFX;

    [SerializeField]
    [Header("BGM�n")]
    SoundBGM[] _soundBGM;


    protected override void Awake()
    {
        base.Awake();

        if (TryGetComponent(out _audioSource))
        {
            Debug.Log("�I�[�f�B�I�\�[�X���Q�Ƃł���");
        }

        FirstBGM();
    }

    void FirstBGM()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case TITLE_SCENE_NAME:
                PlayBGM(BGMType.Title);
                break;

            case GAME_SCENE_NAME:
                PlayBGM(BGMType.Game);
                break;

            case RESULT_SCENE_NAME:
                PlayBGM(BGMType.Result);
                break;
        }

        _audioSource.Play();
    }

    /// <summary>�V�[���ɂ����BGM��ς���֐�</summary>
    /// <param name="type">�V�[���^�C�v</param>
    public void PlayBGM(BGMType type)
    {
        var s = Array.Find(_soundBGM, e => e.Type == type);
        if (s != null)
        {
            _audioSource.PlayOneShot(s.Clip);
        }
        else
        {
            Debug.LogError("AudioClip�������ł�");
        }
    }

    /// <summary>���ʉ���炷���߂̊֐�</summary>
    /// <param name="type">���ʉ��^�C�v</param>
    public void PlaySFX(SFXType type)
    {
        var s = Array.Find(_soundSFX, e => e.Type == type);
        if(s != null)
        {
            _audioSource.PlayOneShot(s.Clip);
        }
        else
        {
            Debug.LogError("AudioClip���Ȃ��ł�");
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

        public BGMType Type => _type;

        [SerializeField]
        BGMType _type;

        [SerializeField]
        AudioClip _clip;
    }
}
