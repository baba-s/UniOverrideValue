# UniOverrideValue

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    public OverrideBool    m_bool;
    public OverrideInt     m_int;
    public OverrideUint    m_uint;
    public OverrideFloat   m_float;
    public OverrideString  m_string;
    public OverrideVector2 m_vector2;
    public OverrideVector3 m_vector3;
    public OverrideColor   m_color;

    private void Awake()
    {
        // Inspector でチェックされている場合は
        // Inspector で設定されている値を取得
        // チェックされていない場合は引数に渡した値を取得
        var result1 = m_string.GetOrDefault( "ピカチュウ" );

        // Inspector でチェックされている場合は
        // Inspector で設定されている値を引数に設定
        var result2 = string.Empty;
        m_string.Override( ref result2 );
    }
    
}
```

![2020-08-23_125921](https://user-images.githubusercontent.com/6134875/90970469-6b5ac580-e540-11ea-907c-e4d52e95dd59.png)
