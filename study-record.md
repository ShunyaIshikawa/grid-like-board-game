# 2021.02.24

- `git add .`時のエラーについて
  - 現象：次のようなエラーが多数出た。
    ```
    warning: LF will be replaced by CRLF in Grid-like Board Game/Library/PackageCache/com.unity.collab-proxy@1.3.9/package.json.The file will have its original line endings in your working directory
    ```
  - 原因：Gitが改行コードをCRLFへ自動変更しようとしている。
  - 解決：`git config --global core.autoCRLF false`を実行する。
  - 参考：[git addしたらCRLF will be replaced by LFなエラー](https://qiita.com/suzuki-koya/items/6b9f1e79b9d662e15afe)