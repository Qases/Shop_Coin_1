using UnityEngine;
using UnityEngine.UI;

namespace SortItems
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private GameObject DefeatScreen;
        [SerializeField] private float time;
        [SerializeField] private Text timerText;
        [SerializeField] private GameObject _getters;
        public DancerAnimation _dancer;

        private float _timeLeft = 0f;
        private bool _timerOn = false;

        private void Start()
        {
            _timeLeft = time;
            _timerOn = true;
        }

        private void Update()
        {
            if (_timerOn)
            {
                if (_timeLeft > 0)
                {
                    _timeLeft -= Time.deltaTime;
                    UpdateTimeText();
                } 
                else
                {
                    _timeLeft = time;
                    _timerOn = false;
                }
            }   
        }

        private void UpdateTimeText()
        {
            if (_timeLeft < 0)
            {
                _timeLeft = 0;
                Defeat();

            }    

            float minutes = Mathf.FloorToInt(_timeLeft / 60);
            float seconds = Mathf.FloorToInt(_timeLeft % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        public void Defeat()
        {
            DefeatScreen.SetActive(true);
            _dancer.PlayDefeat();
            _getters.SetActive(false);
        }
    }
}
