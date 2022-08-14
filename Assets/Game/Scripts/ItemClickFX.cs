using UnityEngine;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFX : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _circleClickFXPrefab;

        public void OnPointerDown(PointerEventData eventData)
        {
            Instantiate(_circleClickFXPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
