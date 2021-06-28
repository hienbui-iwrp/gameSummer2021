using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    public string scene;
    public Vector2 playerPosition;
    public vectorValue playerStorage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals("player"))
        {
            playerStorage.initValue = playerPosition;
            SceneManager.LoadScene(scene);
        }
    }
}
