using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Homework9.Scripts
{
    public abstract class IconFactory : ScriptableObject
    {
        [SerializeField] private Sprite _coinImage;
        [SerializeField] private Sprite _energyImage;

        public virtual Sprite Get(Resources resource, Image image)
        {
            switch (resource)
            {
                case Resources.Coin:
                    image.sprite = _coinImage;
                    return _coinImage;

                case Resources.Energy:
                    image.sprite = _energyImage;
                    return _energyImage;

                default:
                    throw new ArgumentException(nameof(resource));
            }
        }
    }
}
