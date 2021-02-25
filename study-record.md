# 2021.02.24

- `git add .`時のエラーについて
  - 問題：次のようなエラーが多数出た。
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

# 2021.02.25

- 入力フィールドの使い方
  - 参考：[【Unity uGUI】InputFieldを用いてテキスト入力を受け取る方法](https://xr-hub.com/archives/11035)

- シーン間で変数をやり取りする方法
  - 解決：変数、getter、setterにstatic修飾子を付けて、getterとsetterにアクセスする。
  - 注意：`public static`とすると思わぬアクセスを許すので注意。
    - `[SerializeField] static`とすると、修飾子がないことがprivateと解釈され、上の問題を防げそう。
  - 参考：[Unity シーン間で変数を共有する方法](https://qiita.com/YuwUnknown/items/afdc9cd01de7c559ba60)
  - 参考：[【Unity】他のSceneに変数などの情報を渡すカンタンな方法](https://qiita.com/tamoco/items/f5a5015bb1721fbec743)
  - データを書き込んだり読んだりする外部ファイル（csvやjsonなど）を利用しても解決しそう。

- InputFieldに関するエラーが出る
  - 問題：再生時に次のエラーが出続ける。
    ```
    FormatException: Input string was not in a correct format.
    ```
  - 原因：入力文字列を整数に変換する`int.Parse(str)`の引数が不正な状況が発生していた。
  - 解決：`bool int.TryParse(str, out num)`を使う。
  - 参考：[【Unity,C#】型変換のときに例外でも止めずに実行を続ける（TryParse）](https://www.hanachiru-blog.com/entry/2019/12/02/131958)

- Canvasの文字がぼやける
  - 解決：[【unity】Textがぼやけるときの対処](https://qiita.com/tyoberiba225/items/3a44d6b2456b61166276)