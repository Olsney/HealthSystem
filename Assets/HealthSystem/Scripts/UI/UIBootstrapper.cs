using UnityEngine;

namespace Game.UI
{
    public class UIBootstrapper : MonoBehaviour
    {
        [SerializeField] private HealthPresenter _healthPresenter;
        [SerializeField] private HealthModel _healthModel;
        
        public void Awake()
        {
            _healthModel.Init();
            _healthPresenter.Init();
        }
    }
}