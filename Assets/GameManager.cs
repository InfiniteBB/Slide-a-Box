using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void CompleteLevel ()
    {
        Debug.Log ("Level Won");
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
          gameHasEnded = true;
          Debug.Log ("GAME OVER");
        }

    }
}