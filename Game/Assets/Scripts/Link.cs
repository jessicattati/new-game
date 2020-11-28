using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

    public class Link : MonoBehaviour
    {

    public void OpenGithub()
    {
        #if !UNITY_EDITOR
        openWindow("https://github.com/jessicattati/new-game");
        #endif
    }
    public void OpenBrowser()
    {
        #if !UNITY_EDITOR
        openWindow("https://unity.com/");
        #endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);
    
    
}
