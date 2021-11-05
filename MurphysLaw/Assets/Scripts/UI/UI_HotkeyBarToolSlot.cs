using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI
{
    public class UI_HotkeyBarToolSlot : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private Sprite _inactiveIcon;
        [SerializeField] private Sprite _activeIcon;

        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}