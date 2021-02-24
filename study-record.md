# 2021.02.24

- `git add .`時のエラーについて
  - 現象：次のようなエラーが多数出た。
    ```
    warning: LF will be replaced by CRLF in Grid-like Board Game/Library/PackageCache/com.unity.collab-proxy@1.3.9/package.json.The file will have its original line endings in your working directory
    ```
  - 原因：Gitが改行コードをCRLFへ自動変更しようとしている。
  - 解決：`git config --global core.autoCRLF false`を実行する。
  - 参考：[git addしたらCRLF will be replaced by LFなエラー](https://qiita.com/suzuki-koya/items/6b9f1e79b9d662e15afe)

- ピクセル絵の画像をUnityに取り込むとぼやける
  - 現象：ピクセル絵がぼやけてしまう。
  - 解決：画像＞`インスペクター`＞`フィルターモード`を`ポイント（フィルターなし）`に変更する。
  - 参考：[【Unity】ドット絵がぼやけてしまう問題を解決する方法](https://baba-s.hatenablog.com/entry/2018/01/31/213000)

- SerializeFieldの使い方
  - `[SerializeField]`を付けると、インスペクターウィンドウでその変数が編集できる。
  - `public`の場合、編集もできるし、他クラスが書き換えることもできる。
  - `[SerializeField] private`とは書かなくてもよい。
    - 修飾子を書かない場合、暗黙で`private`となる。
  - `[HideInInspector]`を付けると、ウィンドウからは編集できない。シリアライゼーションは行われる。
    - `[HideInInspector] public`と使える。
  - `[System.NonSerialized]`を付けると、そもそもシリアライゼーションが行われない。
  - 参考：[Unityの[SerializeField]について色々な疑問に答えてみる](https://qiita.com/makopo/items/8ef280b00f1cc18aec91#serializefield-private)

- オブジェクトをドラッグ＆ドロップで動かす
  - `WorldToScreenPoint`関数と`ScreenToWorldPoint`をうまく組み合わせる。
  - 参考：[Unityでオブジェクトをドラッグ＆ドロップにあわせて動かす（2D）](https://qiita.com/ReoNagai/items/1becdea9e6fa9b55c82a)

- テキストUIに対して、`GetComponent<Text>().text`が出来ない
  - 問題：次のようなエラーが出る。
    ```
    The type or namespace name 'Text' could not be found
    ```
  - 解決：`using UnityEngine.UI`をプログラム冒頭に記す。