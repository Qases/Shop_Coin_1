using UnityEngine;
using UnityEngine.SceneManagement;

namespace SortItems
{
    public class SceneChanger : MonoBehaviour
    {
        [SerializeField] private GameObject Lvl_Prev;
        [SerializeField] private GameObject Lvl_Next;
        [SerializeField] private GameObject[] CoinBases;



        public void LoadNextLevel()
        {
            if (Lvl_Prev != null)
            {
                Destroy(Lvl_Prev);
            }
            if (CoinBases != null)
            {
                foreach(var _base in CoinBases)
                //Destroy (_base);
                _base.SetActive(false);
            }
            
            //Lvl_Prev.SetActive(false);
            Instantiate(Lvl_Next);        
        }

        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
