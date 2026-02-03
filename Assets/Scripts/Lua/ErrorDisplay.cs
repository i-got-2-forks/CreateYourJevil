using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Class to contain a Lua error message, which is displayed as soon as the Error scene loads.
/// </summary>
public class ErrorDisplay : MonoBehaviour {
    public static string Message;

    private void Start() {
        /*if (GameObject.Find("Main Camera OW")) {
            Destroy(GameObject.Find("Main Camera OW"));
            Destroy(GameObject.Find("Canvas OW"));
            Destroy(GameObject.Find("Canvas Two"));
            Destroy(GameObject.Find("Player"));
        }*/
        UnitaleUtil.firstErrorShown = false;
        GetComponent<Text>().text = Message;
    }
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Y))
		{
			Debug.Log("Error bypassed - may still have bugs");
			SceneManager.UnloadScene("Error");
		}
	}
}