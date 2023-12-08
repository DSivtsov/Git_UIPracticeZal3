using Zenject;

public class LevelInstaller : MonoInstaller
{
  [SerializeField] private CharacterView _characterView;

    public override void InstallBindings()
    {
        Container.Bind<CharacterView>().FromInstance(_characterView).AsCached();
    }  
}
