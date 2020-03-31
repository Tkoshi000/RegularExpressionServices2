
# ホスティング先
- https://regularexpressionservicesme.azurewebsites.NET/

# 概要
- 社外の人にサービスを公開しよう！と1人で始めたプロジェクト

# 作成経緯
- C#の正規表現のテストが出来るサイトがない
- 頻繁に使わないため、リファレンスを毎回探したり、過去のコードを探すため手間
- 正規表現まとめサイトがほしかった

# 技術の選定について
- .NETCore3.1を使ってみたかった
- Razorがどういうものか詳しく知りたかった

# 開発環境について
- Visual Studioを使用
    - テンプレートがあるため、操作が個人的にしやすい。

# ホスティングサービス検討
### 以下選定条件
- Razorを使うため、.dllが扱えるサービス（index.htmlが存在しない)
- .NETcore3.1が使えるサービス
- 無料枠で使える
- 簡単にデプロイできる
- 社外の人でもアクセスできる

### 以下ホスティングサービス
- [Firebase](https://firebase.google.com/?hl=ja)
    - .NETcore3.1 Razorが対応していない
    - Blazorならいけたみたい
- [Heroku](https://jp.heroku.com/)
    - .NETcore3の対応はしている
    - [参考記事](https://blog.kritner.com/2019/10/05/cors-headers-with-dotNETcore-3/)
- [netlify](https://www.netlify.com/)
    - .NETcore3.1 Razorが対応していない
    - Blazorならいけたみたい
- [Azure App Service](https://azure.microsoft.com/ja-jp/services/app-service/)
    - Visual Studio上から出来そう
- 社内サーバーで立てる
    - 社内にIISが立っているためすぐに上げれそう

### 結果
- [Azure App Service](https://azure.microsoft.com/ja-jp/services/app-service/)で立てることにした。

### 理由
- Visual Studio2019から立てる事が非常に簡単すぎてびっくりした。
- 社内でもよかったが、VPNをしないと見れないため社外の人に見せることが難しい

# 参考資料
- 無料プランを使用した結果(以下を参考)
https://qiita.com/hoshimado/items/695db9b278962d67e5ec