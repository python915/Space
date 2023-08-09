
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

namespace SpaceTrip
{
    public class Lives : MonoBehaviour
    {
        public int lives;
        public TMP_Text livesText;
        
        
        
        
        public void TakeLives()
        {
            lives --;
            if (lives == 0)
            {
                SceneManager.LoadScene(2);
                livesText.text = "3";

            }
            else
            {
                SceneManager.LoadScene(1);
                livesText.text = lives.ToString();
            }
            
        }
       
    }
}
