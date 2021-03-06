# Code Quality を測る

## はじめに

Codacy というサービスを使って、コードの品質を測ってみます。

## Codacy とは

コードレビュータイプの CI サービスです。コードレビューするサービスはいくつかありますが、C# をレビューしてくれて Github との連携が簡単なことから今回はこのサービスを使用します。
このサービスはパブリックなリポジトリではフリーになっております。

公式サイト
[codacy](https://www.codacy.com/)

## 使い方

まず Codacy のアカウントを作成します。Github と連携するので、Github のアカウントを使ってサインアップすると連携がスムーズです。
アカウントを作成すると連携するリポジトリを選択する画面になるので、対象にしたいリポジトリを選んでください。
デフォルトでのコード解析の対象は main ブランチになっています。開発は develop ブランチで行うことが多いので、以下のように対象のブランチを変更しておくと良いです。

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/codacy.png?raw=true)

連携ができていれば自動でコードに対する解析が実行され、Files を開くと以下のように各ファイルごとにコードクオリティがどの程度かが表示されます。ここでは ”GrasshopperCISample/Util.cs” の 1 つだけがクオリティ C であることがわかります。

![](https://github.com/hrntsm/zenn_articles/blob/master/books/grasshopper-ci/image/quality.png?raw=true)

該当のファイルを選択するとどこでクオリティが下がっているか確認できるので、修正時は参考にしてください。

## プルリク時に動くようにする

Github の Marketplace からインストールしましょう。
[Marketplace/Apps/Codacy](https://github.com/marketplace/codacy)

## これをやる利点

静的解析しているだけでビルドエラーなどを見ているわけではありません。ですので結果として出てくるものは、例えば以下のようなものになります。

- 使っていない変数がある
- 変数を readonly にできる
- コードの中に重複がある
- リダンダントな表現がある（例えば不要な () など）

これらはもちろん修正しなくてもビルドはできますが、コードの読みやすさから言えば直したほうが望ましい部分たちです。
なくてもよい部分は翌日以降このコードを読むであろう、ナニモワカラナイ自分に向けて、極力きれいにしておくと翌日の自分を助けることができます。

---

### 前のページ
[GitHub Actions でコンポーネントをビルドする](build-with-github-actions)

### 次のページ
[Code Maintainability を測る](code-maintenace)

[トップに戻る](tutorial-chapters)
