<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Singleton Pattern

A MonoBehaviour that exists once in the scene, reachable from anywhere with MyManager.Instance.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/DesignPatternSingleton.git
```

## Use

```csharp
using ArchNet.DesignPattern;

public class GameManager : Singleton<GameManager> { }

GameManager.Instance.StartGame();
```

Tick *Keep Between Scenes* to keep it alive across scene loads.

## License

See [LICENSE.md](LICENSE.md).
