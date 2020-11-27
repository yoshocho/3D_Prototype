# 3D_Prototype
後期末審査会

# プロジェクトの説明
今回作成していゲームは三人称操作のアクションゲームです。
# 実行手順
プロジェクトをダウンロード後、Assets内のScenesの中にあるgame_make_4というSceneを開きます。

# 操作方法
W , A , S , Dキーで移動。スペースキーでジャンプ。マウスでカメラ操作。左クリックで攻撃。


# game説明
プレーンの上にいるスライムの所まで行き、攻撃して倒す所まで作成しました。

# 自分で作成した部分
1,キャラクターや敵のHPバー
2,キャラクターが敵に当たるとシリンダーを減らす
3,キャラクターが敵に当たると少しノックバックする(やりたい事と少し違った)
4,キャラクターのコンボ攻撃（平田さんに教えて貰い作成出来た）

# 発生した問題とその解決方法

問題点
1,前期の審査会でもありましたが、HPバーのシリンダーのゲージが一撃で０まで減る
　＞解決　HPをint型にしたので、C++で習ったキャストを使ってfloatでキャストしました
2,コンボ攻撃の遷移で、次の攻撃に移行しない。
　＞解決　AnyStateから攻撃に移行してたので、Idleからにしたら解決しました。
3,クリティカルダメージを実装したかったがうまくいかなかった
　＞未解決
 # 今後実装予定の物
 ・攻撃時にキャラクターの動きを制御する
 ・キャラクターが敵を攻撃したときにエフェクトや数字を出す
 ・他のキーなどでスキルの実装
 ・スキルを使った時にカメラを切り替える
 ・攻撃、移動時のサウンド
# 参考にしているゲームなど
このゲームの最終的の目標は原神というオープンワールドのアクションRPGゲームです、キャラクターごとに様々な攻撃やスキル
を持っていて、そのアクション性を自分のゲームに取り込めたらいいなと思っています。




