using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{


    //function that can receive animation events
    //functions to play animations for fade in/out

    [SerializeField] Animation _mainMenuAnimator;
    [SerializeField] AnimationClip _fadeOutAnimation;
    [SerializeField] AnimationClip _fadeInAnimation;

    public void onFadeOutComplete(){
        Debug.LogWarning("FadeOut Complete");
    }

    public void onFadeInComplete(){
        Debug.LogWarning("fade in complete");
    }


    public void FadeIn()
    {
        _mainMenuAnimator.Stop();
        _mainMenuAnimator.clip = _fadeInAnimation;
        _mainMenuAnimator.Play();
    }

    public void FadeOut()
    {
        _mainMenuAnimator.Stop();
        _mainMenuAnimator.clip = _fadeOutAnimation;
        _mainMenuAnimator.Play();     

    }
}
