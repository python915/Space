using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceTrip
{
    public class Bootstrap : MonoBehaviour
    {
        public const byte ID_GAME_SCENE = 1;
        void Start()
        {
            LoadGame();
        }


        public void LoadGame()
        {
            SceneManager.LoadScene(ID_GAME_SCENE);
        }
    }
}
