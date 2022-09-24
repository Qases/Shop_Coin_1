using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    public class PlayerScriptableModelProvider : MonoBehaviour
    {
        [SerializeField] protected PlayerScriptableModel _playerScriptableModel;

        public PlayerScriptableModel PlayerScriptableModel =>_playerScriptableModel;

        public void IncreaseScore (int value)
        {
            _playerScriptableModel.AddScore(value);
        }

        public void DecreaseScore (int value)
        {
            _playerScriptableModel.AddScore(-value);
        }
    }
}
