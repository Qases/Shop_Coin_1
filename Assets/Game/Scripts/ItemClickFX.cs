using UnityEngine;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _circleClickFXPrefab;
        //[SerializeField] private ParticlesPoolProvider _particlesPoolProvider;

        public void OnPointerDown(PointerEventData eventData)
        {
            //ParticlesPoolItem itemInstance = _particlesPoolProvider.ParticlesPool.GetFromPool();
            //itemInstance.transform.position = transform.position;
            //itemInstance.ParticleSystem.Play();
            
            Instantiate(_circleClickFXPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
