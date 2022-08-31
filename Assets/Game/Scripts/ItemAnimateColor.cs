using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace SortItems
{
    public class ItemAnimateColor : MonoBehaviour
    {
        [SerializeField] private Color _destinationColor = Color.white;
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private float _animationTime = .3f;

        private bool _isAnimate = false;
        private Material _itemMaterial;
        private Color _ItemSrcColor;
        private float _elapsedTime;

        private void Awake() 
        {
            _itemMaterial = _meshRenderer.material;
            _ItemSrcColor = _itemMaterial.color;
        }

        public void Animation()
        {
            if (_isAnimate)
            {

                return;

            }


            _isAnimate = true;

            _elapsedTime = 0f;

            StartCoroutine(AnimateColor());
        }

        protected IEnumerator AnimateColor()
        {
            while (_elapsedTime < _animationTime)
            {
                yield return new WaitForEndOfFrame();

                _itemMaterial.color = Color.Lerp(_ItemSrcColor, _destinationColor, Mathf.PingPong(2*_elapsedTime/_animationTime, 1));

                

                _elapsedTime +=Time.deltaTime;

            }

            _isAnimate = false;
        }


    }
}
