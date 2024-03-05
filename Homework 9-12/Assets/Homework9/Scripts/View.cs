using UnityEngine;
using UnityEngine.UI;

namespace Assets.Homework9.Scripts
{
    public class View : MonoBehaviour
    {
        [SerializeField] private ShopIconsFactory _shopIconFactory;
        [SerializeField] private LobbyIconsFactory _lobbyIconFactory;
        [SerializeField] private Image _coinPosition;
        [SerializeField] private Image _energyPosition;

        private IconFactory _currentIconFactory;

        private void Awake()
        {
            SetFactory(_lobbyIconFactory);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SetFactory(_lobbyIconFactory);
            }
            if(Input.GetKeyDown(KeyCode.R)) 
            {
                SetFactory(_shopIconFactory);
            }
        }

        private void Show()
        {
            _currentIconFactory.Get(Resources.Coin, _coinPosition);
            _currentIconFactory.Get(Resources.Energy, _energyPosition);
        }

        private void SetFactory(IconFactory factory)
        {
            _currentIconFactory = factory;
            Show();
        }
    }
}
