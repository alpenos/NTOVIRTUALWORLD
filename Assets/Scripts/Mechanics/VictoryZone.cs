using Platformer.Gameplay;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            GameObject warning = GameObject.Find("warning");
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (PlayerPrefs.GetInt("TestInventory") != 0 && PlayerPrefs.GetInt("TestInventory2") != 0 && PlayerPrefs.GetInt("TestInventory3") != 0)
            {
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                warning.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        void OnTriggerExit2D(Collider2D collider)
        {
            GameObject warning = GameObject.Find("warning");
            warning.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
            