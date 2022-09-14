using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    public class ChangeGameStateTo : MonoBehaviour
    {
        [SerializeField] private GameStateMachine _gameStateMachine;
        [SerializeField] private GameState _gameState;

        public GameStateMachine GameStateMachine => _gameStateMachine;

        public void OnChangeState()
        {
            GameStateMachine.GameState = _gameState;
        }
    }
}
