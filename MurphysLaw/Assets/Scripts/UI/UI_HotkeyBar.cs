using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Player
{
    public class UI_HotkeyBar : MonoBehaviour
    {
        [SerializeField] private Sprite _inactiveBack;
        [SerializeField] private Sprite _activeBack;

        [SerializeField] private HotkeySystemPresenter _hotkeySystemPresenter;
        [SerializeField] private List<Transform> _slots;
        private Transform _template;

        // Use this for initialization
        void Start()
        {
            _template = transform.Find("toolSlotTemplate");
            _template.gameObject.SetActive(false);
            LoadVisual();
        }

        private void OnEnable()
        {
            _hotkeySystemPresenter.OnToolChangedPresent += OnToolChanged;
        }

        private void OnToolChanged(int index)
        {
            UpdateVisual(index);
        }

        private void LoadVisual()
        {
            List<Tool> toolList = _hotkeySystemPresenter.GetToolList();
            for (int i = 0; i < toolList.Count; i++)
            {
                Tool tool = toolList[i];
                Transform toolSlotTransform = Instantiate(_template, transform);
                toolSlotTransform.gameObject.SetActive(true);
                RectTransform toolSlotRectTransform = toolSlotTransform.GetComponent<RectTransform>();
                toolSlotRectTransform.anchoredPosition = new Vector2(100f * i, 0f);

                toolSlotTransform.Find("icon").GetComponent<Image>().sprite = tool.Icon;
                toolSlotTransform.Find("numberText").GetComponent<TMPro.TextMeshProUGUI>().SetText((i + 1).ToString());

                _slots.Add(toolSlotTransform);
            }
        }

        private void UpdateVisual(int index)
        {
            for (int i = 0; i < _slots.Count; i++)
            {
                if(i == index)
                {
                    _slots[i].Find("background").GetComponent<Image>().sprite = _activeBack;
                }
                else
                {
                    _slots[i].Find("background").GetComponent<Image>().sprite = _inactiveBack;
                }
            }
        }
    }
}