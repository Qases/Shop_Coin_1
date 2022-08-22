using UnityEngine;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        //[SerializeField] private GameObject _circleClickFXPrefab;
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;

        public void OnPointerDown(PointerEventData eventData)
        {
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();
            
            //Instantiate(_circleClickFXPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
