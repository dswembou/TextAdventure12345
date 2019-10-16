using System;
using UnityEngine;
using UnityEngine.Assertions;

public class Keyboard : MonoBehaviour
{
    [SerializeField] AudioClip[] keyStrokeSounds;
    [SerializeField] Terminal connectedToTerminal;

    AudioSource audioSource;


    public string FinalText;
    private int i = 0;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        QualitySettings.vSyncCount = 0; // No V-Sync so Update() not held back by render
        Application.targetFrameRate = 1000; // To minimise delay playing key sounds
        WarnIfTerminalNotConneced();
        NieuwKarakter();
    }

    private void WarnIfTerminalNotConneced()
    {
        if (!connectedToTerminal)
        {
            Debug.LogWarning("Keyboard not connected to a terminal");
        }
    }

    private void Update()
    {
        bool isValidKey = Input.inputString.Length > 0;
        if (isValidKey)
        {
            PlayRandomSound();
        }
        if (connectedToTerminal)
        {
            connectedToTerminal.ReceiveFrameInput(Input.inputString);
        }

        if (i < FinalText.Length)
        {
            NieuwKarakter();
        }
    }

    void NieuwKarakter()
    {
        if (Time.time > 2f)
        {
            if (connectedToTerminal)
            {
                connectedToTerminal.ReceiveFrameInput(FinalText.Substring(i, 1));
                i++;
            }

            
        }
    }

    private void PlayRandomSound()
    {
        int randomIndex = UnityEngine.Random.Range(0, keyStrokeSounds.Length);
        audioSource.clip = keyStrokeSounds[randomIndex];
        audioSource.Play();
    }
}
