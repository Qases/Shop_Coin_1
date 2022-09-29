using UnityEngine;

namespace SortItems
{
    public class DancerAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        private static readonly int Defeat = Animator.StringToHash("PlayDefeat");
        private static readonly int Dansing = Animator.StringToHash("PlayDansing");

        public void PlayDefeat()
        {
            _animator.SetTrigger(Defeat);
        }

        public void PlayDansing()
        {
            _animator.SetTrigger(Dansing);
        }
    }
}
