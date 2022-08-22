using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        //[SerializeField] private GameObject _circleClickFXPrefab;
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;
        public UnityEvent OnClick;

        public void OnPointerDown(PointerEventData eventData)
        {
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();

            OnClick.Invoke();
            
            //Instantiate(_circleClickFXPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
