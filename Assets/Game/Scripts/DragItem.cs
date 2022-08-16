using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace SortItems
{
    public class DragItem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        [SerializeField] private float upForce = 50f;
        [SerializeField] private ItemType _type;

        public UnityEvent OnHideRequest;
     
        private Rigidbody _rigidbody;

        public bool isDraggable { get; private set; }
     
        public ItemType Type { get => _type; }

        private void Start() 
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (!isDraggable) return;

            if (eventData.pointerCurrentRaycast.isValid)
            {
                var pos = eventData.pointerCurrentRaycast.worldPosition;
                var delta = pos - transform.position;
                delta.y = 0;

                transform.position += delta;
            }
            else
            {
                DropItem();
            }
            
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            PickItem();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            DropItem();
        }

        private void PickItem()
        {
            _rigidbody.isKinematic = true;
            isDraggable = true;
        }

        private void DropItem()
        {
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(Vector3.up * upForce);
            isDraggable = false;
        }
    }
}
