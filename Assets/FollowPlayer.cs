
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Camera cam;
    

    private void Update()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(0, player.position.y, -10);
        } else if (cam.transform.position.y > player.transform.position.y + 50)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
