using UnityEngine;

public class AudioService : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField]
    private AudioSource soundSource;
    [SerializeField]
    private AudioSource musicSource;

    [Header("Sound Clips")]
    [SerializeField]
    private AudioClip normalBtnSound;
    [SerializeField]
    private AudioClip selectBtnSound;
    [SerializeField]
    private AudioClip gameWinSound;
    [SerializeField]
    private AudioClip gameLoseSound;
    [SerializeField]
    private AudioClip playBtnSound;
    [SerializeField]
    private AudioClip cardFlipSound;
    [SerializeField]
    private AudioClip matchCardSound;
    [SerializeField]
    private AudioClip startLevelSound;
    [SerializeField]
    private AudioClip wrongMatchSound;
    [SerializeField]
    private AudioClip fireWorksSound;
    [SerializeField]
    private AudioClip cheerSound;

    [Header("Music Clips")]
    [SerializeField]
    private AudioClip bgMusicMainMenu;
    [SerializeField]
    private AudioClip bgMusicGameplay;

    public void PlayWinSound()
    {
        musicSource.Stop();
        soundSource.PlayOneShot(gameWinSound);
    }
    public void PlayLoseSound()
    {
        //musicSource.Stop();
        soundSource.PlayOneShot(gameLoseSound);
    }
    public void NormalBtnSound()
    {
        soundSource.PlayOneShot(normalBtnSound);
    }
    public void SelectBtnSound()
    {
        soundSource.PlayOneShot(selectBtnSound);
    }
    public void PlayBtnSound()
    {
        soundSource.PlayOneShot(playBtnSound);
    }
    public void PlayMainMenuMusic()
    {
        musicSource.clip = bgMusicMainMenu;
        musicSource.Play();
        musicSource.loop = true;
    }
    public void PlayGameplayMusic()
    {
        musicSource.clip = bgMusicGameplay;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayCustomSound(AudioClip audioClip)
    {
        soundSource.PlayOneShot(audioClip);
    }

    public void PlayCustomMusic(AudioClip audioClip)
    {
        musicSource.clip = audioClip;
        musicSource.loop = true;
        musicSource.Play();
    }
    public void PlayCardFlipSound()
    {
        soundSource.PlayOneShot(cardFlipSound);
    }
    public void CardMatchSound()
    {
        soundSource.PlayOneShot(matchCardSound);
    }
    public void StartLevel()
    {
        soundSource.PlayOneShot(startLevelSound);
    }

    public void WrongMatch()
    {
        soundSource.PlayOneShot(wrongMatchSound);
    }

    public void FireWorksSound()
    {
        soundSource.PlayOneShot(fireWorksSound);
    }
    public void PlayCheerSound()
    {
        soundSource.PlayOneShot(cheerSound);
    }
}
