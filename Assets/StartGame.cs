using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class StartGame : MonoBehaviour
{
    //public GUITexture menu1 = null;
    //public GUITexture submenu1 = null;
    //public GUITexture submenu2 = null;
    //private bool menu1Expanded = false;
    //public string loadlevel; 

    public void ChangeScene(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    // Use this for initialization
    void Start () {
        

}

    // Update is called once per frame
    void Update() {
        //OnGUI(); 
    }

    #region IGvrGazeResponder implementation

    /// Called when the user is looking on a GameObject with this script,
    /// as long as it is set to an appropriate layer (see GvrGaze).
    public void OnGazeEnter()
    {
        Debug.Log("On Gaze Enter");
    }

    /// Called when the user stops looking on the GameObject, after OnGazeEnter
    /// was already called.
    public void OnGazeExit()
    {
        Debug.Log("On Gaze Exit");
    }

    /// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
    public void OnGazeTrigger()
    {
        Debug.Log("On Gaze Trigger");
        //Debug.Log(NetworkManager.singleton);
        //NetworkManager.singleton.matchMaker.CreateMatch("match", 4, true, "", "", "", 0, 0, OnMatchCreate);
    }

    #endregion
    /*
    void LoadLevel()
    {
        SceneManager.LoadScene(loadlevel);
        /*
        if (GUI.Button(new Rect(10, 10, 120, 50), "menu1"))
        {
            menu1Expanded = !menu1Expanded;
            // do you menu1 stuff
        }

        if (menu1Expanded)
        {
            if (GUI.Button(new Rect(10, 60, 50, 50), "submenu1"))
            {

                // do you submenu1 stuff
            }

            if (GUI.Button(new Rect(60, 60, 50, 50), "submenu2"))
            {

                // do you submenu2 stuff
            }
        } */
        
    } 


